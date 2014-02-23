using System;
using System.Globalization;

namespace ByteartRetailMini.Web.Controls
{
    public partial class Logon : System.Web.UI.UserControl
    {
        public Services.OrderService OrderService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.IsAuthenticated)
            {
                Controls.Remove(LogonTable);
                var shoppingCartCount = OrderService.GetShoppingCartItemCount(Context.User.Identity.Name);
                ShoppingCartCountSpan.InnerText = shoppingCartCount.ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                Controls.Remove(WellcomeTable);
            }
        }
    }
}