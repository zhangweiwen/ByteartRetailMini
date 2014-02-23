using ByteartRetailMini.Web.IViews.Account;

namespace ByteartRetailMini.Web.Presenters.Account
{
    public class LogonPresenter
    {
        private readonly ILogon _view;
        private readonly Services.UserService _userService;

        public LogonPresenter(ILogon view, Services.UserService userService)
        {
            _view = view;
            _userService = userService;
            _view.LoginBtnClick += OnLoginBtnClick;
        }

        private void OnLoginBtnClick(string userName, string password)
        {
            var validateSuccess = _userService.ValidateUser(userName, password);
            if (validateSuccess)
            {
                _view.SetCookieAndRedirect();
            }
            else
            {
               _view.LogonError(); 
            }
        }
    }
}