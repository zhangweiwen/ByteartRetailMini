using ByteartRetailMini.Web.IViews.Controls;
using ByteartRetailMini.Web.Services;

namespace ByteartRetailMini.Web.Presenters.Controls
{
    public class CategoriesPresenter
    {
        private readonly ICategories _view;
        private readonly ProductService _productService;

        public CategoriesPresenter(ICategories view, ProductService productService)
        {
            _view = view;
            _productService = productService;
            _view.PageLoad += OnPageLoad;
        }

        private void OnPageLoad()
        {
            var categories = _productService.GetCategories();
            _view.BindCategories(categories);
        }
    }
}