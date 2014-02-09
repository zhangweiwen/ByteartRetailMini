using System;
using System.Web;
using System.Web.UI;
using Autofac;
using Autofac.Integration.Web;

namespace ByteartRetailMini.Web.Core
{
    public class DependencyResolvingUserControl : UserControl
    {
        protected override void OnInit(EventArgs e)
        {
            var cpa = (IContainerProviderAccessor)HttpContext.Current.ApplicationInstance;
            var cp = cpa.ContainerProvider;
            cp.RequestLifetime.InjectProperties(this);
            base.OnInit(e);
        }
    }
}