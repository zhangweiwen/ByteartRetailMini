using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Autofac;
using Autofac.Extras.DynamicProxy2;
using ByteartRetailMini.Domain.Mappings;
using ByteartRetailMini.Domain.Models;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Testing.Values;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHibernate;
using NHibernate.Linq;
using NHibernate.Tool.hbm2ddl;
using NLog;
using NLog.Config;
using NLog.Targets;

namespace ByteartRetailMini.Test
{
    [TestClass]
    public partial class NHibernateTestCast
    {
        [TestInitialize]
        public void Setup()
        {
            BuildSessionFactory(true);
        }

        [TestMethod]
        public void QueryProductTest()
        {
            using (var session = SessionFactory.OpenSession())
            {
                //var products = session.Query<Product>()
                //    .Where(p => p.ID == Guid.Parse("9C36236E-56CC-4B3D-8405-934C084CF8FA"))
                //    .Where(p => p.Name == "惠普Deskjet 1050 彩色喷墨打印机")
                //    .Where(p => p.UnitPrice == 339M)
                //    .ToList();
                var product = session.Get<Product>(Guid.Parse("9C36236E-56CC-4B3D-8405-934C084CF8FA"));
                Assert.IsNotNull(product);
                Console.WriteLine(product.Name);
                //Console.WriteLine("Count => {0}", products.Count);
                //foreach (var product in products)
                //{
                //    Console.WriteLine(product.ID);
                //    Console.WriteLine(product.Name);
                //    Console.WriteLine("==========");
                //}
            }
        }

        [TestMethod]
        public void AopTest()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<AopTest>().AsSelf().EnableClassInterceptors()
                .InterceptedBy(typeof(LogInterceptor));
            builder.RegisterType<LogInterceptor>();
            var aop = builder.Build().Resolve<AopTest>();
            aop.Add(1, 3);
        }

        [TestMethod]
        public void InitByteData()
        {
            using (var session = SessionFactory.OpenSession())
            {
                foreach (var user in InitData.Users)
                {
                    var id = (int)session.Save(user);
                    Console.WriteLine(user.ID);
                }
                foreach (var product in InitData.Products)
                {
                    var id = (int)session.Save(product);
                    Console.WriteLine(id);
                }
                foreach (var category in InitData.Categories)
                {
                    var id = (int)session.Save(category);
                    Console.WriteLine(id);
                }
                foreach (var role in InitData.Roles)
                {
                    var id = (int)session.Save(role);
                    Console.WriteLine(id);
                }
                foreach (var categorization in InitData.Categorizations)
                {
                    var id = (int)session.Save(categorization);
                    Console.WriteLine(id);
                }
                foreach (var userRole in InitData.UserRoles)
                {
                    var id = (int)session.Save(userRole);
                    Console.WriteLine(id);
                }
                session.Flush();
            }
        }
    }

    public partial class NHibernateTestCast
    {
        private const string DbFile = @"Byte.sqlite";
        private const string HbmPath = @"..\..\Hbms";
        private const string DbScriptFile = @"db.sql";

        protected static ISessionFactory SessionFactory;

        protected static void BuildSessionFactory(bool buildTables = false)
        {
            SessionFactory = Fluently.Configure()
                .Database(SQLiteConfiguration.Standard.ShowSql().AdoNetBatchSize(0).UsingFile(DbFile))
                //.Database(MsSqlConfiguration.MsSql2012.ShowSql().ConnectionString(x => x.FromConnectionStringWithKey("bbm")))
                .Mappings(m =>
                {
                    m.FluentMappings.AddFromAssemblyOf<ProductMap>();
                    m.FluentMappings.ExportTo(HbmPath);

                }).ExposeConfiguration(c =>
                {
                    if (buildTables)
                    {
                        var schema = new SchemaExport(c);
                        schema.SetOutputFile(DbScriptFile).Execute(true, true, false);
                    }
                }).BuildSessionFactory();
        }
    }

    public static class InitData
    {
        private static List<User> _users;
        public static List<User> Users
        {
            get
            {
                if (_users != null)
                    return _users;

                _users = new List<User>
                {
                    new User
                    {
                        UserName = "daxnet",
                        Password = "daxnet",
                        Email = "daxnet@ByteartRetail.com",
                        IsDisabled = false,
                        DateRegistered = DateTime.Now,
                        DateLastLogon = null,
                        Contact = "dax.net",
                        PhoneNumber = "0123-45678912",
                        ContactAddress =new Address
                        {
                            Country = "中国",
                            City = "上海市",
                            State = "上海市",
                            Street = "ABC大道63号，DEF大厦G楼",
                            Zip = "200000",

                        },
                        DeliveryAddress = new Address
                        {
                            Country = "中国",
                            City = "上海市",
                            State = "上海市",
                            Street = "ABC大道63号，DEF大厦G楼",
                            Zip = "200000"
                        },
                    },
                    new User
                    {
                        UserName = "buyer",
                        Password = "buyer",
                        Email = "buyer@ByteartRetail.com",
                        IsDisabled = false,
                        DateRegistered = DateTime.Now,
                        DateLastLogon = null,
                        Contact = "buyer",
                        PhoneNumber = "1234567",
                        ContactAddress =new Address
                        {
                            Country = "中国",
                            City = "上海市",
                            State = "上海市",
                            Street = "ABC大道",
                            Zip = "200000",

                        },
                        DeliveryAddress = new Address
                        {
                            Country = "中国",
                            City = "上海市",
                            State = "上海市",
                            Street = "ABC大道",
                            Zip = "200000"
                        },
                    },
                    new User
                    {
                        UserName = "admin",
                        Password = "admin",
                        Email = "admin@ByteartRetail.com",
                        IsDisabled = false,
                        DateRegistered = DateTime.Now,
                        DateLastLogon = null,
                        Contact = "admin",
                        PhoneNumber = "1234567",
                        ContactAddress =new Address
                        {
                            Country = "中国",
                            City = "上海市",
                            State = "上海市",
                            Street = "ABC大道",
                            Zip = "200000",

                        },
                        DeliveryAddress = new Address
                        {
                            Country = "中国",
                            City = "上海市",
                            State = "上海市",
                            Street = "ABC大道",
                            Zip = "200000"
                        },
                    },
                    new User
                    {
                        UserName = "sales",
                        Password = "sales",
                        Email = "sales@ByteartRetail.com",
                        IsDisabled = false,
                        DateRegistered = DateTime.Now,
                        DateLastLogon = null,
                        Contact = "sales",
                        PhoneNumber = "1234567",
                        ContactAddress =new Address
                        {
                            Country = "中国",
                            City = "上海市",
                            State = "上海市",
                            Street = "ABC大道",
                            Zip = "200000",

                        },
                        DeliveryAddress = new Address
                        {
                            Country = "中国",
                            City = "上海市",
                            State = "上海市",
                            Street = "ABC大道",
                            Zip = "200000"
                        },
                    },
                };
                return _users;
            }
        }

        private static List<Product> _products;
        public static List<Product> Products
        {
            get
            {
                if (_products != null)
                    return _products;

                _products = new List<Product>
                {
                    new Product
                    {
                        Name = "ZTE 中兴 V970 3G手机",
                        ImageUrl = "dd34e809_b1fc_4c75_b8f9_c5444a64cb47.jpg",
                        UnitPrice = 975,
                        IsFeatured = false,
                        Description = @"ZTE 中兴 V970 3G手机(黑色)WCDMA/GSM 双卡双待安卓4.0+1GHz双核处理器+4.3寸QHD高清大屏"
                    },
                    new Product
                    {
                        Name = "ZTE 中兴 V889M",
                        ImageUrl = "a1c1738a_eaba_4c4c_b683_7c5b4eb64306.jpg",
                        UnitPrice = 784,
                        IsFeatured = false,
                        Description = @"ZTE 中兴 V889M 智能双卡双待3G手机(黑)联通定制 1GHz双核处理器 4.0英寸超大炫屏"
                    },
                    new Product
                    {
                        Name = "DELL 戴尔 V260SR-526 台式电脑",
                        ImageUrl = "43dd3fe6_4203_41dd_b570_2c9eacb7c021.jpg",
                        UnitPrice = 2749,
                        IsFeatured = false,
                        Description = @"DELL 戴尔 V260SR-526 台式电脑(G630 2G 500G DVD Linux 18.5英寸宽屏液晶 三年上门服务)。选择节约空间、使用与拥有同样简单的台式机，简化您的工作空间。Vostro成就260s超薄塔式机可配备第2代英特尔®酷睿™处理器，以及将普通办公室转变为动态工作环境所需的必要组件。"
                    },
                    new Product
                    {
                        Name = "惠普6460B（WX560AV）",
                        ImageUrl = "b182e978_85e1_474d_84e3_e505441e9000.jpg",
                        UnitPrice = 6900,
                        IsFeatured = true,
                        Description = @"CPU型号：Intel 酷睿i5 2520M; 屏幕尺寸：14英寸; 内存容量：2GB; 硬盘容量：320GB"
                    },
                    new Product
                    {
                        Name = "Lenovo 联想 IdeaCentre Q180",
                        ImageUrl = "2d3df03f_0663_4f9a_8f6c_cb0af683cd23.jpg",
                        UnitPrice = 1799,
                        IsFeatured = false,
                        Description = @"Lenovo 联想 IdeaCentre Q180 台式电脑主机(凌动D2700 2G 320G 512M独显 无线网卡 WIN7 2年保修含1年上门)"
                    },
                    new Product
                    {
                        Name = "联想ThinkPad Tablet 2",
                        ImageUrl = "774f83b1_e90d_4ff1_a148_f90af591a865.jpg",
                        UnitPrice = 6487,
                        IsFeatured = true,
                        Description = @"操作系统：Windows 8屏幕尺寸：10.1英寸处理器：Intel Atom摄像头：双摄像头（前置：200屏幕分辨：1366x768WiFi功能：WIFI无线上网续航时间：10小时左右，具体时间上市时间：2012年声音系统：双立体声扬声器，内置屏幕描述：电容式触摸屏，多点式"
                    },
                    new Product
                    {
                        Name = "三星GALAXY Tab P6800",
                        ImageUrl = "d633a09b_479f_4af2_af9d_635b7a59e1b7.jpg",
                        UnitPrice = 3599,
                        IsFeatured = true,
                        Description = @"操作系统：Android3.2屏幕尺寸：7.7英寸系统内存：1GB存储容量：16GB处理器：双核，1.4GHz摄像头：双摄像头（前置：200网络模式：支持3G网络屏幕分辨：1280x800GPS导航：内置GPS导航WiFi功能：支持802.11a/b/g/n无"
                    },
                    new Product
                    {
                        Name = "联想G460A-PSI",
                        ImageUrl = "bc2dbf1a_699a_4eaf_a49f_4eccc199bb55.jpg",
                        UnitPrice = 3360,
                        IsFeatured = true,
                        Description = @"CPU型号：Intel 奔腾双核 P6200屏幕尺寸：14英寸内存容量：2GB硬盘容量：320GBCPU主频：2.13GHz笔记本重：2.2Kg"
                    },
                    new Product
                    {
                        Name = "联想G470A-IFI",
                        ImageUrl = "c9285a49_972c_4356_a893_3e2a4e45c17d.jpg",
                        UnitPrice = 3465,
                        IsFeatured = true,
                        Description = @"CPU型号：Intel 酷睿i5 2450M屏幕尺寸：14英寸内存容量：2GB硬盘容量：500GBCPU主频：2.5GHz笔记本重：2.2Kg"
                    },
                    new Product
                    {
                        Name = "SAMSUNG 三星S7562",
                        ImageUrl = "333c0de9_cae2_4458_a675_3560e8525ae5.jpg",
                        UnitPrice = 1578,
                        IsFeatured = false,
                        Description = @"SAMSUNG 三星S7562双卡3G智能手机(白)Android 4.0操作系统 4.0英寸大屏 1GHz处理器"
                    },
                    new Product
                    {
                        Name = "惠普LaserjetM1005黑白激光一体机",
                        ImageUrl = "dafeaaed_0b93_45ea_8b04_00dd86c62d5e.jpg",
                        UnitPrice = 1459,
                        IsFeatured = true,
                        Description = @"HP 惠普  LaserjetM1005 黑白激光一体机(打印 扫描 复印)。"
                    },
                    new Product
                    {
                        Name = "惠普G42-382TX（XU766PA）",
                        ImageUrl = "bc0d0d76_3d79_472e_86bb_63a9376d2bab.jpg",
                        UnitPrice = 3860,
                        IsFeatured = true,
                        Description = @"CPU型号：Intel 酷睿i3 370M屏幕尺寸：14英寸内存容量：2GB硬盘容量：500GBCPU主频：2.4GHz笔记本重：2.2Kg"
                    },
                    new Product
                    {
                        Name = "惠普Envy 4-1008tx（B4P51PA）",
                        ImageUrl = "29ebfc59_e14a_49bc_9a41_d0796f392475.jpg",
                        UnitPrice = 5399,
                        IsFeatured = true,
                        Description = @"CPU型号：Intel 酷睿i5 3317U屏幕尺寸：14英寸内存容量：4GB硬盘容量：500GBCPU主频：1.7GHz笔记本重：1.75Kg"
                    },
                    new Product
                    {
                        Name = "NOKIA 诺基亚Lumia 800C",
                        ImageUrl = "82d1556f_1238_43ce_a5fd_410cc246162e.jpg",
                        UnitPrice = 1585,
                        IsFeatured = true,
                        Description = @"NOKIA 诺基亚Lumia 800C 全新WP系统 时尚智能3G手机(电信定制 WP Mango系统 黑)"
                    },
                    new Product
                    {
                        Name = "惠普Deskjet 1050 彩色喷墨打印机",
                        ImageUrl = "d5d4367d_ab87_4687_8d7c_d1544acf50d1.jpg",
                        UnitPrice = 339,
                        IsFeatured = false,
                        Description = @"HP 惠普 惠众系列 Deskjet 1050 彩色喷墨多功能一体机(打印 复印 扫描)。惠普（HP）惠众系列 Deskjet 1050 彩色喷墨多功能一体机 （打印 复印 扫描）具有更低的使用成本。超低价HP 802S墨盒
配合单墨盒打印/复印，使用成本经济快速安装配合快速开机，操作更方便、快捷。hp1050 彩色喷墨多功能一体机核心特点：销量领先，品质放心 
即使在极端条件下，也可顺利开展工作。HP Deskjet 1050经过精心设计和严格测试，可以在炎热、潮湿或布满灰尘的环境下可靠运行. 
Deskjet 1050核心特点，符合能源之星® 认证（ENERGY STAR®）
大幅降低打印机的能源成本。节能，环保，省钱。 "
                    },
                };
                return _products;
            }
        }

        private static List<Category> _categories;
        public static List<Category> Categories
        {
            get
            {
                if (_categories != null)
                    return _categories;

                _categories = new List<Category>
                {
                    new Category
                    {
                        Name = "台式电脑",
                        Description = "各种品牌的台式电脑"
                    },
                    new Category
                    {
                        Name = "笔记本电脑",
                        Description = "各种品牌的笔记本电脑"
                    },
                    new Category
                    {
                        Name = "手机",
                        Description = "手机"
                    },
                    new Category
                    {
                        Name = "平板设备",
                        Description = "包括平板电脑和MID设备"
                    },
                    new Category
                    {
                        Name = "打印机",
                        Description = "打印机设备"
                    },
                };
                return _categories;
            }
        }

        private static List<Role> _roles;
        public static List<Role> Roles
        {
            get
            {
                if (_roles != null)
                    return _roles;

                _roles = new List<Role>
                {
                    new Role
                    {
                        Name = "SalesReps",
                        Description = "用于管理销售方面的专员角色"
                    },
                    new Role
                    {
                        Name = "Buyers",
                        Description = "用于管理采购方面的专员角色"
                    },
                    new Role
                    {
                        Name = "Customers",
                        Description = "普通客户角色"
                    },
                    new Role
                    {
                        Name = "Administrators",
                        Description = "系统管理员角色"
                    },
                };
                return _roles;
            }
        }

        private static List<Categorization> _categorizations;
        public static List<Categorization> Categorizations
        {
            get
            {
                if (_categorizations != null)
                    return _categorizations;

                var products = Products.OrderBy(x => x.UnitPrice).ToArray();
                var pad = Categories.FirstOrDefault(x => x.Name.Contains("平板"));
                var phone = Categories.FirstOrDefault(x => x.Name.Contains("手机"));
                var laptop = Categories.FirstOrDefault(x => x.Name.Contains("笔记本"));
                var pc = Categories.FirstOrDefault(x => x.Name.Contains("台式"));
                var printer = Categories.FirstOrDefault(x => x.Name.Contains("打印机"));
                Debug.Assert(pad != null);
                Debug.Assert(phone != null);
                Debug.Assert(laptop != null);
                Debug.Assert(pc != null);
                Debug.Assert(printer != null);
                _categorizations = new List<Categorization>
                {
                    new Categorization { CategoryID = printer.ID, ProductID = products[0].ID},
                    new Categorization { CategoryID = phone.ID, ProductID = products[1].ID},
                    new Categorization { CategoryID = phone.ID, ProductID = products[2].ID},
                    new Categorization { CategoryID = printer.ID, ProductID = products[3].ID},
                    new Categorization { CategoryID = phone.ID, ProductID = products[4].ID},
                    new Categorization { CategoryID = phone.ID, ProductID = products[5].ID},
                    new Categorization { CategoryID = pc.ID, ProductID = products[6].ID},
                    new Categorization { CategoryID = pc.ID, ProductID = products[7].ID},
                    new Categorization { CategoryID = pc.ID, ProductID = products[8].ID},
                    new Categorization { CategoryID = pc.ID, ProductID = products[9].ID},
                    new Categorization { CategoryID = pad.ID, ProductID = products[10].ID},
                    new Categorization { CategoryID = pc.ID, ProductID = products[11].ID},
                    new Categorization { CategoryID = pc.ID, ProductID = products[12].ID},
                    new Categorization { CategoryID = pad.ID, ProductID = products[13].ID},
                    new Categorization { CategoryID = pc.ID, ProductID = products[14].ID},
                };
                return _categorizations;
            }
        }

        private static List<UserRole> _userRoles;
        public static List<UserRole> UserRoles
        {
            get
            {
                if (_userRoles != null)
                    return _userRoles;

                var daxnet = Users.FirstOrDefault(x => x.UserName == "daxnet");
                var buyer = Users.FirstOrDefault(x => x.UserName == "buyer");
                var admin = Users.FirstOrDefault(x => x.UserName == "admin");
                var sales = Users.FirstOrDefault(x => x.UserName == "sales");

                var saleRole = Roles.FirstOrDefault(x => x.Name == "SalesReps");
                var buyerRole = Roles.FirstOrDefault(x => x.Name == "Buyers");
                var customers = Roles.FirstOrDefault(x => x.Name == "Customers");
                var adminRole = Roles.FirstOrDefault(x => x.Name == "Administrators");

                _userRoles = new List<UserRole>
                {
                    new UserRole { RoleID = adminRole.ID, UserID = admin.ID},
                    new UserRole { RoleID = buyerRole.ID, UserID = buyer.ID},
                    new UserRole { RoleID = saleRole.ID, UserID = sales.ID},
                    new UserRole { RoleID = customers.ID, UserID = daxnet.ID},
                };
                return _userRoles;
            }
        }
    }
}