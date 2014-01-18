using ByteartRetailMini.Domain.Models;
using FluentNHibernate.Mapping;

namespace ByteartRetailMini.Domain.Mappings
{
    public sealed class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Table("Products");
            Id(x => x.ID);
            Map(x => x.Name).Length(40).Not.Nullable();
            Map(x => x.ImageUrl);
            Map(x => x.UnitPrice).Precision(18).Scale(2).Not.Nullable();
            Map(x => x.IsFeatured).Not.Nullable();
            Map(x => x.Description).Length(4001).Not.Nullable();
        }
    }
}