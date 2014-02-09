using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using ByteartRetailMini.Web.Core;
using ByteartRetailMini.Web.IViews.Controls;
using ByteartRetailMini.Web.Presenters.Controls;
using ByteartRetailMini.Web.Services;

namespace ByteartRetailMini.Web.Controls
{
    public partial class Categories : DependencyResolvingUserControl, ICategories
    {
        private CategoriesPresenter _presenter;

        public event Action PageLoad;

        public ProductService ProductService { get; set; }

        protected void Page_Init(object sender, EventArgs e)
        {
            _presenter = new CategoriesPresenter(this, ProductService);
            CategoriesRpt.ItemDataBound += OnProductRptItemDataBound;
        }
    }

    public partial class Categories
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PageLoad();
        }
    }

    public partial class Categories
    {
        public void BindCategories(IList<CategoryDataObject> categories)
        {
            CategoriesRpt.DataSource = categories;
            CategoriesRpt.DataBind();
        }

        private static void OnProductRptItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                var category = e.Item.DataItem as CategoryDataObject;
                var categoryLink = e.Item.FindControl("CategoryLink") as HtmlAnchor;
                Debug.Assert(category != null);
                Debug.Assert(categoryLink != null);

                var productUrl = string.Format("/Home/Category?id={0}", category.ID);
                categoryLink.HRef = productUrl;
                categoryLink.InnerText = category.Name;
            }
        }
    }
}