using ByteartRetailMini.Domain.Models;
using FluentNHibernate.Mapping;

namespace ByteartRetailMini.Domain.Mappings
{
    public sealed class CategoryMap : ClassMap<Category>
    {
        public CategoryMap()
        {
            Table("Categories");
            Id(x => x.ID);
            Map(x => x.Name).Not.Nullable();
            Map(x => x.Description).Length(4001);
        }
    }
}