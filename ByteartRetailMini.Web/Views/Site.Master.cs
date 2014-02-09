using System;
using System.Security.Principal;
using System.Web.UI;
using ByteartRetailMini.Web.Core;
using ByteartRetailMini.Web.IViews;
using ByteartRetailMini.Web.Presenters;
using ByteartRetailMini.Web.Services;

namespace ByteartRetailMini.Web.Views
{
    //初始化部分
    public partial class Site : MasterPage, ISiteMaster
    {
        private SiteMasterPresenter _presenter;

        public event Action<IIdentity> PageLoad;

        public UserService UserService { get; set; }

        protected void Page_Init(object sender, EventArgs e)
        {
            _presenter = new SiteMasterPresenter(this, UserService);
        }
    }

    //请求部分
    public partial class Site
    {
        private void Page_Load(object sender, EventArgs e)
        {
            PageLoad(Context.User.Identity);
        }
    }

    //回应部分
    public partial class Site
    {
        public void RemoveNotAuthenticatedLinks()
        {
            Controls.Remove(MyLink);
            Controls.Remove(AdminLink);
        }

        public void RemoveLinkByRole(Role role)
        {
            switch (role)
            {
                case Role.None:
                    {
                        Controls.Remove(AdminLink);
                        Controls.Remove(RolesLink);
                        Controls.Remove(ProductsLink);
                        Controls.Remove(CategoriesLink);
                        Controls.Remove(UserAccountsLink);
                        Controls.Remove(AdminSalesOrdersLink);
                        break;
                    }
                case Role.Administrators:
                    {
                        break;
                    }
                case Role.Buyers:
                    {
                        Controls.Remove(RolesLink);
                        Controls.Remove(UserAccountsLink);
                        Controls.Remove(AdminSalesOrdersLink);
                        break;
                    }
                case Role.Customers:
                    {
                        Controls.Remove(AdminLink);
                        Controls.Remove(RolesLink);
                        Controls.Remove(ProductsLink);
                        Controls.Remove(CategoriesLink);
                        Controls.Remove(UserAccountsLink);
                        Controls.Remove(AdminSalesOrdersLink);
                        break;
                    }
                case Role.SalesReps:
                    {
                        Controls.Remove(RolesLink);
                        Controls.Remove(ProductsLink);
                        Controls.Remove(CategoriesLink);
                        Controls.Remove(UserAccountsLink);
                        break;
                    }
            }
        }
    }
}