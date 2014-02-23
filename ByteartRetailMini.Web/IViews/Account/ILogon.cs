using System;

namespace ByteartRetailMini.Web.IViews.Account
{
    public partial interface ILogon
    {
        event Action<string, string> LoginBtnClick;
    }

    public partial interface ILogon
    {
        void SetCookieAndRedirect();
        void LogonError();
    }
}