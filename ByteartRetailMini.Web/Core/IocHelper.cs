using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using Autofac.Integration.Web;

namespace ByteartRetailMini.Web.Core
{
    public class IocHelper
    {
        private static readonly ContainerBuilder Builder = new ContainerBuilder();

        public static IContainer Container { get; private set; }

        public static void Init()
        {
            RegisterServices();
            Container = Builder.Build();
        }

        private static void RegisterServices()
        {
            Builder.RegisterType<UserService.UserServiceClient>()
                .As<UserService.UserService>()
                .InstancePerHttpRequest();
        }
    }
}