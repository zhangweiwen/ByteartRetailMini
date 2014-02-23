using ByteartRetailMini.Domain.Models;
using FluentNHibernate.Mapping;

namespace ByteartRetailMini.Domain.Mappings
{
    public sealed class ShoppingCartItemMap : ClassMap<ShoppingCartItem>
    {
        public ShoppingCartItemMap()
        {
            Table("ShoppingCartItems");
            Id(x => x.ID);
            Map(x => x.Quantity).Not.Nullable();
            References(x => x.Product).Not.LazyLoad();
            References(x => x.ShoppingCart);
        }
    }
}