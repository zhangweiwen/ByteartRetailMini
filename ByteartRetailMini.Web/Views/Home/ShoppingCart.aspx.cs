using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using ByteartRetailMini.Web.Core;
using ByteartRetailMini.Web.IViews.Home;
using ByteartRetailMini.Web.Presenters.Home;
using ByteartRetailMini.Web.Services;

namespace ByteartRetailMini.Web.Views.Home
{
    public partial class ShoppingCart : AuthorizePage, IShoppingCart
    {
        private ShoppingCartPresenter _presenter;

        public event Action<string> PageLoad;

        public OrderService OrderService { get; set; }

        protected void Page_Init(object sender, EventArgs e)
        {
            _presenter = new ShoppingCartPresenter(this, OrderService);
            ShoppingCartItemsRpt.ItemDataBound += OnShoppingCartItemsRptItemDataBound;
        }
    }

    public partial class ShoppingCart
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var userName = User.Identity.Name;
            PageLoad(userName);
        }
    }

    public partial class ShoppingCart
    {
        public void BindShoppingCartItems(List<ShoppingCartItemDataObject> shoppingCartItems)
        {
            ShoppingCartItemsRpt.DataSource = shoppingCartItems;
            ShoppingCartItemsRpt.DataBind();
        }

        private void OnShoppingCartItemsRptItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                var shoppingCartItem = e.Item.DataItem as ShoppingCartItemDataObject;
                var productImg = e.Item.FindControl("ProductImg") as HtmlImage;
                var productLink = e.Item.FindControl("ProductLink") as HtmlAnchor;
                var priceTd = e.Item.FindControl("PriceTd") as HtmlTableCell;
                var quantityTxt = e.Item.FindControl("QuantityTxt") as HtmlInputText;
                var sumPriceTd = e.Item.FindControl("SumPriceTd") as HtmlTableCell;
                var updateImg = e.Item.FindControl("UpdateImg") as HtmlImage;
                var deleteImg = e.Item.FindControl("DeleteImg") as HtmlImage;

                Debug.Assert(priceTd != null);
                Debug.Assert(shoppingCartItem != null);
                Debug.Assert(updateImg != null);
                Debug.Assert(deleteImg != null);
                Debug.Assert(productImg != null);
                Debug.Assert(sumPriceTd != null);
                Debug.Assert(productLink != null);
                Debug.Assert(quantityTxt != null);

                var productUrl = string.Format("/Home/Product?id={0}", shoppingCartItem.Product.ID);
                productImg.Src = string.Format("/Images/Products/{0}", shoppingCartItem.Product.ImageUrl);
                productLink.HRef = productUrl;
                priceTd.InnerText = string.Format("{0:N2} 元", shoppingCartItem.Product.UnitPrice);
                quantityTxt.Value = shoppingCartItem.Quantity.ToString();
                quantityTxt.ID = "quantity_" + shoppingCartItem.ID;
                sumPriceTd.InnerText = string.Format("{0:N2} 元", shoppingCartItem.LineAmount);
                updateImg.ID = string.Format("update_{0}", shoppingCartItem.ID);
                deleteImg.ID = string.Format("delete_{0}", shoppingCartItem.ID);
            }
        }

        public void BindSummary(ShoppingCartDataObject shoppingCart)
        {
            SumQuantityTd.InnerText = string.Format("{0:##,#}", shoppingCart.Items.Sum(i => i.Quantity));
            TotalSumPrice.InnerText = string.Format("{0:N2} 元", shoppingCart.Subtotal);
        }
    }
}