using FluentNHibernate.Mapping;

namespace ByteartRetailMini.Domain.NHibernate
{
    public sealed class SalesLineMap : ClassMap<SalesLine>
    {
        public SalesLineMap()
        {
            Table("SalesLines");
            Id(x => x.ID);
            Map(x => x.Quantity).Not.Nullable();
            References(x => x.Product);
            References(x => x.SalesOrder);
        }
    }
}