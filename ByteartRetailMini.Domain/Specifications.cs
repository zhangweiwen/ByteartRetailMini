using System;
using System.Linq.Expressions;
using ByteartRetailMini.Domain.Models;

namespace ByteartRetailMini.Domain
{
    public class Specifications
    {
        public static Expression<Func<ShoppingCartItem, bool>> ShoppingItemBelongsToCart(ShoppingCart shoppingCart)
        {
            return p => p.ShoppingCart.ID == shoppingCart.ID;
        }
    }
}