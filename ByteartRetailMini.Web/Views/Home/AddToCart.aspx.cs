using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ByteartRetailMini.Web.Services;

namespace ByteartRetailMini.Web.Views.Home
{
    public partial class AddToCart : Page
    {
        public OrderService OrderService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            var quantity = 1;
            int productID;
            int.TryParse(Request.Form["items"], out quantity);
            int.TryParse(Request.Form["ctl00$MainContent$ProductIdInput"], out productID);
            OrderService.AddProductToCart(User.Identity.Name, productID, quantity);
            Response.Redirect("/Home/ShoppingCart");
        }
    }
}