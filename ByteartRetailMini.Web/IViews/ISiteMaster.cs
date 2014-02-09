using System;
using System.Security.Principal;
using ByteartRetailMini.Web.Core;

namespace ByteartRetailMini.Web.IViews
{
    public partial interface ISiteMaster
    {
        event Action<IIdentity> PageLoad;
    }

    public partial interface ISiteMaster
    {
        void RemoveNotAuthenticatedLinks();
        void RemoveLinkByRole(Role role);
    }
}