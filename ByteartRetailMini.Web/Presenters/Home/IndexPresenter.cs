using Autofac;
using ByteartRetailMini.Web.Core;
using ByteartRetailMini.Web.IViews.Home;

namespace ByteartRetailMini.Web.Presenters.Home
{
    public class IndexPresenter
    {
        private readonly IIndex _index;
        private readonly Services.ProductService _productService;

        public IndexPresenter(IIndex index, Services.ProductService productService)
        {
            _index = index;
            _productService = productService;
            _index.PageLoad += OnPageLoad;
        }

        private void OnPageLoad()
        {
            var featuredProducts = _productService.GetFeaturedProducts(4);
            _index.BindFeaturedProducts(featuredProducts);
        }
    }
}