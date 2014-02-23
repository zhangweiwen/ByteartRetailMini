using System.Diagnostics;
using ByteartRetailMini.Web.Core;
using ByteartRetailMini.Web.IViews.Controls;
using ByteartRetailMini.Web.Services;

namespace ByteartRetailMini.Web.Presenters.Controls
{
    public sealed class ProductsPresenter
    {
        private readonly IProducts _view;
        private readonly ProductService _productService;

        public ProductsPresenter(IProducts view, ProductService productService)
        {
            _view = view;
            _productService = productService;
            _view.PageLoad += OnPageLoad;
        }

        private void OnPageLoad(int pageIndex, int categoryID)
        {
            var pageInfo = new PageInfo
            {
                PageIndex = pageIndex == 0 ? 1 : pageIndex,
                PageSize = Constants.PageSize
            };
            PagedListOfProductDataObjectUqqArW2s products;
            var categoryName = "所有商品";
            if (categoryID > 0)
            {
                products = _productService.GetProductsForCategoryWithPagination(categoryID, pageInfo);
                categoryName = _productService.GetCategoryByID(categoryID).Name;
            }
            else
            {
                products = _productService.GetProductsWithPagination(pageInfo);
            }
            Debug.Assert(products != null);
            if (products.Items == null || products.Items.Count == 0)
            {
                _view.ShowNotFound();
                return;
            }
            _view.BindProducts(products);
            if (categoryID > 0)
            {
                _view.BindCategory(categoryName);                
            }
            _view.BindPageInfo(categoryID, products);
        }
    }
}