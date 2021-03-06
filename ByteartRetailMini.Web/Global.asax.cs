﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using Autofac.Integration.Web;
using ByteartRetailMini.Web.Core;

namespace ByteartRetailMini.Web
{
    public class Global : HttpApplication, IContainerProviderAccessor
    {
        private static IContainerProvider _containerProvider;

        public IContainerProvider ContainerProvider
        {
            get { return _containerProvider; }
        }

        private void Application_Start(object sender, EventArgs e)
        {
            RegisterRoutes(RouteTable.Routes);
            IocHelper.Init();
            _containerProvider = new ContainerProvider(IocHelper.Container);
        }

        private static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute("home", "", "~/Views/Home/Index.aspx");
            routes.MapPageRoute("default", "{section}/{page}", "~/Views/{section}/{page}.aspx");
        }

        private void Application_End(object sender, EventArgs e)
        {
            //  在应用程序关闭时运行的代码

        }

        private void Application_Error(object sender, EventArgs e)
        {
            // 在出现未处理的错误时运行的代码

        }

        private void Session_Start(object sender, EventArgs e)
        {
            // 在新会话启动时运行的代码

        }

        private void Session_End(object sender, EventArgs e)
        {
            // 在会话结束时运行的代码。 
            // 注意: 只有在 Web.config 文件中的 sessionstate 模式设置为
            // InProc 时，才会引发 Session_End 事件。如果会话模式设置为 StateServer 
            // 或 SQLServer，则不会引发该事件。

        }
    }
}
