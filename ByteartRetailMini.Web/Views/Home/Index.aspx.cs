using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using ByteartRetailMini.Web.IViews.Home;
using ByteartRetailMini.Web.Presenters.Home;
using ByteartRetailMini.Web.Services;

namespace ByteartRetailMini.Web.Views.Home
{
    public partial class Index : Page, IIndex
    {
        private IndexPresenter _presenter;

        public event Action PageLoad;

        public ProductService ProductService { get; set; }

        protected void Page_Init(object sender, EventArgs e)
        {
            _presenter = new IndexPresenter(this, ProductService);
            ProductRpt.ItemDataBound += OnProductRptItemDataBound;
        }
    }

    public partial class Index
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PageLoad();
        }
    }

    public partial class Index
    {
        public void BindFeaturedProducts(List<ProductDataObject> products)
        {
            ProductRpt.DataSource = products;
            ProductRpt.DataBind();
        }

        private static void OnProductRptItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                var product = e.Item.DataItem as ProductDataObject;
                var productImg = e.Item.FindControl("ProductImg") as HtmlImage;
                var productLink = e.Item.FindControl("ProductLink") as HtmlAnchor;
                var productTextLink = e.Item.FindControl("ProductTextLink") as HtmlAnchor;
                Debug.Assert(product != null);
                Debug.Assert(productImg != null);
                Debug.Assert(productLink != null);
                Debug.Assert(productTextLink != null);

                var productUrl = string.Format("/Home/Product?id={0}", product.ID);
                productLink.HRef = productUrl;
                productTextLink.HRef = productUrl;
                productTextLink.InnerText = product.Name;
                productImg.Src = string.Format("/Images/Products/{0}", product.ImageUrl);
            }
        }
    }
}