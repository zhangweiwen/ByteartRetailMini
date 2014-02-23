using System;
using System.Diagnostics;
using System.Security.Policy;
using System.Security.Principal;
using System.Web.Security;
using System.Web.UI;
using ByteartRetailMini.Web.Core;
using ByteartRetailMini.Web.IViews.Account;
using ByteartRetailMini.Web.Presenters;
using ByteartRetailMini.Web.Presenters.Account;
using ByteartRetailMini.Web.Services;

namespace ByteartRetailMini.Web.Views.Account
{
    public partial class Logon : Page, ILogon
    {
        private LogonPresenter _presenter;

        public event Action<string, string> LoginBtnClick;

        public UserService UserService { get; set; }

        protected void Page_Init(object sender, EventArgs e)
        {
            _presenter = new LogonPresenter(this, UserService);            
        }
    }

    public partial class Logon
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void OnLoginBtnClick(object sender, EventArgs e)
        {
            var userName = Request.Form["UserName"];
            var password = Request.Form["Password"];

            Debug.Assert(userName != null);
            Debug.Assert(password != null);
            LoginBtnClick(userName, password);
        }
    }

    public partial class Logon
    {
        public void SetCookieAndRedirect()
        {
            var rememberMe = false;
            var userName = Request.Form["UserName"];
            var rememberMeString = Request.Form["RememberMe"];
            var returnUrl = Request.Form["returnUrl"] ?? string.Empty;
            bool.TryParse(rememberMeString, out rememberMe);
            FormsAuthentication.SetAuthCookie(userName, rememberMe);
            if (Helper.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/") && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
            {
                Response.Redirect(returnUrl);
            }
            else
            {
                Response.Redirect(@"/Home/Index");
            }
        }

        public void LogonError()
        {
            ValidationError.Visible = true;
        }
    }
}