using System;
using System.Linq;
using Autofac;
using Autofac.Extras.DynamicProxy2;
using ByteartRetailMini.Domain.Mappings;
using ByteartRetailMini.Domain.Models;
using ByteartRetailMini.Infrastructure;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHibernate;
using NHibernate.Linq;
using NHibernate.Tool.hbm2ddl;

namespace ByteartRetailMini.Test
{
    [TestClass]
    public class NHibernateTestCast
    {
        //private const string DbFile = @"ByteartRetailMini.sqlite";
        private const string HbmPath = @"..\..\Hbms";
        private const string DbScriptFile = @"db.sql";

        protected static ISessionFactory SessionFactory;

        protected static void BuildSessionFactory(bool buildTables = false)
        {
            SessionFactory = Fluently.Configure()
                //.Database(SQLiteConfiguration.Standard.ShowSql().UsingFile(DbFile))
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(x => x.FromConnectionStringWithKey("bbm")))
                .Mappings(m =>
                {
                    m.FluentMappings.AddFromAssemblyOf<ProductMap>();
                    m.FluentMappings.ExportTo(HbmPath);

                }).ExposeConfiguration(c =>
                {
                    c.SetInterceptor(new SqlInterceptor());
                    if (buildTables)
                    {
                        var schema = new SchemaExport(c);
                        schema.SetOutputFile(DbScriptFile).Execute(true, true, false);
                    }
                }).BuildSessionFactory();
        }

        [TestMethod]
        public void QueryProductTest()
        {
            BuildSessionFactory(true);
            using (var session = SessionFactory.OpenSession())
            {
                var products = session.Query<Product>().ToList();
                Console.WriteLine("Count => {0}", products.Count);
                foreach (var product in products)
                {
                    Console.WriteLine(product.ID);
                    Console.WriteLine(product.Name);
                    Console.WriteLine("==========");
                }
            }
        }

        [TestMethod]
        public void AopTest()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<AopTest>().AsSelf().EnableClassInterceptors()
                .InterceptedBy(typeof (LogInterceptor));
            builder.RegisterType<LogInterceptor>();
            var aop = builder.Build().Resolve<AopTest>();
            aop.Add(1, 3);
        }
    }
}