using ByteartRetailMini.Domain.Models;
using FluentNHibernate.Mapping;

namespace ByteartRetailMini.Domain.Mappings
{
    public sealed class SalesLineMap : ClassMap<SalesLine>
    {
        public SalesLineMap()
        {
            Table("SalesLines");
            Id(x => x.ID);
            Map(x => x.Quantity).Not.Nullable();
            References(x => x.Product);
            References(x => x.SalesOrder).Not.Nullable();
        }
    }
}