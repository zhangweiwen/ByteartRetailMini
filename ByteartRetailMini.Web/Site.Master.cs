using System;
using System.Web.UI;

namespace ByteartRetailMini.Web
{
    public partial class Site : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Context.User.Identity.IsAuthenticated == false)
            {
                Controls.Remove(MyLink);
                Controls.Remove(AdminLink);
            }
        }
    }
}