using FluentNHibernate.Mapping;

namespace ByteartRetailMini.Domain.NHibernate
{
    public sealed class SalesOrderMap : ClassMap<SalesOrder>
    {
        public SalesOrderMap()
        {
            Table("SalesOrders");
            Id(x => x.ID);
            Map(x => x.Status);
            Map(x => x.DateCreated).Not.Nullable();
            Map(x => x.DateDispatched);
            Map(x => x.DateDelivered);
            References(x => x.User);
        }
    }
}