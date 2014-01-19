using System;
using System.Security.Principal;
using ByteartRetailMini.Web.Core;

namespace ByteartRetailMini.Web
{
    public sealed class SiteMasterPresenter
    {
        private readonly ISiteMaster _siteMaster;
        private readonly UserService.UserService _userService;

        public SiteMasterPresenter(ISiteMaster siteMaster, UserService.UserService userService)
        {
            _siteMaster = siteMaster;
            _userService = userService;
            _siteMaster.PageLoad += OnPageLoad;
        }

        private void OnPageLoad(IIdentity identity)
        {
            if (identity.IsAuthenticated && string.IsNullOrWhiteSpace(identity.Name) == false)
            {
                var userRole = _userService.GetUserRole(Guid.Parse(identity.Name));
                if (userRole == null)
                {
                    _siteMaster.RemoveNotAuthenticatedLinks();
                    return;
                }
                var role = (Role)Enum.Parse(typeof(Role), userRole.Name);
                _siteMaster.RemoveLinkByRole(role);
            }
            else
            {
                _siteMaster.RemoveNotAuthenticatedLinks();
            }
        }
    }
}