using ByteartRetailMini.Web.IViews.Home;
using ByteartRetailMini.Web.Services;

namespace ByteartRetailMini.Web.Presenters.Home
{
    public class ShoppingCartPresenter
    {
        private readonly IShoppingCart _view;
        private readonly OrderService _orderService;

        public ShoppingCartPresenter(IShoppingCart view, OrderService orderService)
        {
            _view = view;
            _orderService = orderService;
            _view.PageLoad += OnPageLoad;
        }

        private void OnPageLoad(string userName)
        {
            var shoppingCart = _orderService.GetShoppingCart(userName);
            if (shoppingCart != null && shoppingCart.Items != null && shoppingCart.Items.Count > 0)
            {
                _view.BindShoppingCartItems(shoppingCart.Items);
                _view.BindSummary(shoppingCart);
            }
        }
    }
}