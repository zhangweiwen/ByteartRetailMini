using FluentNHibernate.Mapping;

namespace ByteartRetailMini.Domain.NHibernate
{
    public sealed class ShoppingCartItemMap : ClassMap<ShoppingCartItem>
    {
        public ShoppingCartItemMap()
        {
            Table("ShoppingCartItems");
            Id(x => x.ID);
            Map(x => x.Quantity).Not.Nullable();
            References(x => x.Product);
            References(x => x.ShoppingCart);
        }
    }
}