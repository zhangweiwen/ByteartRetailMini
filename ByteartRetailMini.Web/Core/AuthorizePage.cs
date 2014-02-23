using System.Web.UI;

namespace ByteartRetailMini.Web.Core
{
    public class AuthorizePage : Page
    {
        public void Page_Init()
        {
            if (User.Identity.IsAuthenticated == false)
            {
                Response.Redirect("/Account/Logon");
            }
        }
    }
}