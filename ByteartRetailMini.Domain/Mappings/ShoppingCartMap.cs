using ByteartRetailMini.Domain.Models;
using FluentNHibernate.Mapping;

namespace ByteartRetailMini.Domain.Mappings
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