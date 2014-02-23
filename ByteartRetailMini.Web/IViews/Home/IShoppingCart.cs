using System;
using System.Collections.Generic;
using ByteartRetailMini.Web.Services;

namespace ByteartRetailMini.Web.IViews.Home
{
    public partial interface IShoppingCart
    {
        event Action<string> PageLoad;
    }

    public partial interface IShoppingCart
    {
        void BindShoppingCartItems(List<Services.ShoppingCartItemDataObject> shoppingCartItems);
        void BindSummary(ShoppingCartDataObject shoppingCart);
    }
}