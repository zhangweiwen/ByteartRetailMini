using System;
using System.Diagnostics;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using ByteartRetailMini.Web.Core;
using ByteartRetailMini.Web.IViews.Controls;
using ByteartRetailMini.Web.Presenters.Controls;
using ByteartRetailMini.Web.Services;

namespace ByteartRetailMini.Web.Controls
{
    public partial class Products : DependencyResolvingUserControl, IProducts
    {
        public event Action<int,int> PageLoad;
        private ProductsPresenter _presenter;

        public ProductService ProductService { get; set; }

        protected void Page_Init(object sender, EventArgs e)
        {
            _presenter = new ProductsPresenter(this, ProductService);
            ProductsRpt.ItemDataBound += OnProductsRptItemDataBound;
        }
    }

    public partial class Products
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            int page;
            int categoryID;
            int.TryParse(Request.QueryString["page"] ?? string.Empty, out page);
            int.TryParse(Request.QueryString["categoryID"] ?? string.Empty, out categoryID);
            PageLoad(page, categoryID);
        }
    }

    public partial class Products
    {
        public void ShowNotFound()
        {
            NotFoundMsg.Visible = true;
        }

        public void BindProducts(PagedListOfProductDataObjectUqqArW2s products)
        {
            ProductsRpt.DataSource = products.Items;
            ProductsRpt.DataBind();
        }

        public void BindPageInfo(int categoryID, PagedListOfProductDataObjectUqqArW2s products)
        {
            if (products.PageIndex == 1)
            {
                FirstLink.Disabled = true;
                PrevLink.Disabled = true;
            }
            else
            {
                var prevIndex = products.PageIndex - 1;
                var firstUrl = "/Home/Index?page=1";
                var prevUrl = string.Format("/Home/Index?page={0}", prevIndex);
                if (categoryID > 0)
                {
                    firstUrl = string.Format("/Home/Category?categoryID={0}&page=1", categoryID);
                    prevUrl = string.Format("/Home/Category?categoryID={0}&page={1}", categoryID, prevIndex);
                }
                FirstLink.HRef = firstUrl;
                PrevLink.HRef = prevUrl;
            }
            if (products.PageIndex == products.TotalPage)
            {
                NextLink.Disabled = true;
                LastLink.Disabled = true;
            }
            else
            {
                var nextIndex = products.PageIndex + 1;
                var nextUrl = string.Format("/Home/Index?page={0}", nextIndex);
                var lastUrl = string.Format("/Home/Index?page={0}", products.TotalPage);
                if (categoryID > 0)
                {
                    nextUrl = string.Format("/Home/Index?categoryID={0}&page={1}", categoryID, nextIndex);
                    lastUrl = string.Format("/Home/Index?categoryID={0}&page={1}", categoryID, products.TotalPage);
                }
                NextLink.HRef = nextUrl;
                LastLink.HRef = lastUrl;
            }
        }

        public void BindCategory(string categoryName)
        {
            CategoryName.InnerText = categoryName;
        }

        private static void OnProductsRptItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                var product = e.Item.DataItem as ProductDataObject;
                var buyLink = e.Item.FindControl("BuyLink") as HtmlAnchor;
                var priceTd = e.Item.FindControl("PriceTd") as HtmlTableCell;
                var productImg = e.Item.FindControl("ProductImg") as HtmlImage;
                var detailLink = e.Item.FindControl("DetailLink") as HtmlAnchor;
                var productImgLink = e.Item.FindControl("ProductImgLink") as HtmlAnchor;
                var productNameLink = e.Item.FindControl("ProductNameLink") as HtmlAnchor;
                Debug.Assert(product != null);
                Debug.Assert(buyLink != null);
                Debug.Assert(priceTd != null);
                Debug.Assert(productImg != null);
                Debug.Assert(detailLink != null);
                Debug.Assert(productImgLink != null);
                Debug.Assert(productNameLink != null);

                var price = string.Format("{0:N2} {1}", product.UnitPrice, "元");
                var productUrl = string.Format("/Home/Product?id={0}", product.ID);
                var bugUrl = string.Format("/Home/AddToCart?item=1&id={0}", product.ID);
                var productImgPath = string.Format("/Images/Products/{0}", product.ImageUrl);

                buyLink.HRef = bugUrl;
                priceTd.InnerText = price;
                detailLink.HRef = productUrl;
                productImg.Src = productImgPath;
                productImgLink.HRef = productUrl;
                productNameLink.HRef = productUrl;
                productNameLink.InnerText = product.Name;
            }
        }
    }
}