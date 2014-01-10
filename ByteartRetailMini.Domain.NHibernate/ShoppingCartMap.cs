using FluentNHibernate.Mapping;

namespace ByteartRetailMini.Domain.NHibernate
{
    public sealed class ShoppingCartMap : ClassMap<ShoppingCart>
    {
        public ShoppingCartMap()
        {
            Table("ShoppingCarts");
            Id(x => x.ID);
            References(x => x.User);
        }
    }
}