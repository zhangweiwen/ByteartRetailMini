using ByteartRetailMini.Domain.Models;
using FluentNHibernate.Mapping;

namespace ByteartRetailMini.Domain.Mappings
{
    public sealed class CategorizationMap : ClassMap<Categorization>
    {
        public CategorizationMap()
        {
            Table("Categorizations");
            Id(x => x.ID);
            Map(x => x.CategoryID).Not.Nullable();
            Map(x => x.ProductID).Not.Nullable();
        }
    }
}