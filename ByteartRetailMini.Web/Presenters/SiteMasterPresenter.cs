using System;
using System.Security.Principal;
using Autofac;
using ByteartRetailMini.Web.Core;
using ByteartRetailMini.Web.IViews;

namespace ByteartRetailMini.Web.Presenters
{
    public sealed class SiteMasterPresenter
    {
        private readonly ISiteMaster _siteMaster;
        private readonly Services.UserService _userService;

        public SiteMasterPresenter(ISiteMaster siteMaster, Services.UserService userService)
        {
            _siteMaster = siteMaster;
            _userService = userService;
            _siteMaster.PageLoad += OnPageLoad;
        }

        private void OnPageLoad(IIdentity identity)
        {
            if (identity.IsAuthenticated && string.IsNullOrWhiteSpace(identity.Name) == false)
            {
                var userRole = _userService.GetUserRole(identity.Name);
                if (userRole == null)
                {
                    _siteMaster.RemoveNotAuthenticatedLinks();
                    return;
                }
                var role = (Role)Enum.Parse(typeof(Role), userRole.Name);
                _siteMaster.LogonSuccess(role);
            }
            else
            {
                _siteMaster.RemoveNotAuthenticatedLinks();
            }
        }
    }
}