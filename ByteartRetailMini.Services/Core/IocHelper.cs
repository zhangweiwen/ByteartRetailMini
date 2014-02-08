using Autofac;
using Autofac.Extras.DynamicProxy2;
using ByteartRetailMini.Domain.Mappings;
using ByteartRetailMini.Domain.Services;
using ByteartRetailMini.Infrastructure;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace ByteartRetailMini.Services.Core
{
    public class IocHelper
    {
        private const string DbScriptFile = @"db.sql";
        private static readonly ContainerBuilder Builder = new ContainerBuilder();

        public static IContainer Container { get; private set; }

        public static void Init()
        {
            RegisteNHibernate();
            RegisteAppServices();
            RegisteWcfServices();
            Container = Builder.Build();
        }

        public static void RegisteNHibernate()
        {
            Builder.Register(c => BuildSessionFactory()).As<ISessionFactory>().SingleInstance();
        }

        private static void RegisteAppServices()
        {
            Builder.Register(c =>
            {
                var session = c.Resolve<ISessionFactory>().GetCurrentSession();
                return new DomainService(session);
            }).As<IDomainService>();
            Builder.Register(c =>
            {
                var session = c.Resolve<ISessionFactory>().GetCurrentSession();
                var domainService = c.Resolve<IDomainService>();
                return new Application.UserService(session, domainService);
            }).As<Application.IUserService>();
            Builder.Register(c =>
            {
                var session = c.Resolve<ISessionFactory>().GetCurrentSession();
                var domainService = c.Resolve<IDomainService>();
                return new Application.OrderService(session, domainService);
            }).As<Application.IOrderService>();
            Builder.Register(c => new Application.PostbackService()).As<Application.IPostbackService>();
            Builder.Register(c =>
            {
                var session = c.Resolve<ISessionFactory>().GetCurrentSession();
                var domainService = c.Resolve<IDomainService>();
                return new Application.ProductService(session, domainService);
            }).As<Application.IProductService>();
        }

        private static void RegisteWcfServices()
        {
            Builder.RegisterType<AopInterceptor>().AsSelf();
            Builder.RegisterType<UserService>().AsSelf().EnableClassInterceptors().InterceptedBy(typeof(AopInterceptor));
            Builder.RegisterType<OrderService>().AsSelf().EnableClassInterceptors().InterceptedBy(typeof(AopInterceptor));
            Builder.RegisterType<ProductService>().AsSelf().EnableClassInterceptors().InterceptedBy(typeof(AopInterceptor));
            Builder.RegisterType<PostbackService>().AsSelf().EnableClassInterceptors().InterceptedBy(typeof(AopInterceptor));
        }

        public static ISessionFactory BuildSessionFactory(bool buildTables = false)
        {
            return Fluently.Configure()
                .Database(SQLiteConfiguration.Standard.ShowSql().ConnectionString(c => c.FromConnectionStringWithKey("byte")))
                .CurrentSessionContext("wcf_operation")
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<ProductMap>()).ExposeConfiguration(c =>
                {
                    c.SetInterceptor(new SqlInterceptor());
                    if (buildTables)
                    {
                        var schema = new SchemaExport(c);
                        schema.SetOutputFile(DbScriptFile).Execute(false, true, false);
                    }
                }).BuildSessionFactory();
        }
    }
}