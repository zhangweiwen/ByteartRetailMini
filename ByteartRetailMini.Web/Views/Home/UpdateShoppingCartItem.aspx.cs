using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ByteartRetailMini.Web.Core;
using ByteartRetailMini.Web.Services;

namespace ByteartRetailMini.Web.Views.Home
{
    public partial class UpdateShoppingCartItem : AuthorizePage
    {
        public OrderService OrderService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            int quantity;
            int shoppingCartItemID;
            int.TryParse(Request.Form["quantity"], out quantity);
            int.TryParse(Request.Form["shoppingCartItemID"], out shoppingCartItemID);
            if (quantity > 0 && shoppingCartItemID > 0)
            {
                OrderService.UpdateShoppingCartItem(shoppingCartItemID, quantity);
                Response.Write(string.Empty);
            }
        }
    }
}