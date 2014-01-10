using FluentNHibernate.Mapping;

namespace ByteartRetailMini.Domain.NHibernate
{
    public sealed class RoleMap : ClassMap<Role>
    {
        public RoleMap()
        {
            Table("Roles");
            Id(x => x.ID);
            Map(x => x.Name).Length(25).Not.Nullable();
            Map(x => x.Description).Length(4001);
        }
    }
}