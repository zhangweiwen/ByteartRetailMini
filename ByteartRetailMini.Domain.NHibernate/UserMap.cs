using FluentNHibernate.Mapping;

namespace ByteartRetailMini.Domain.NHibernate
{
    public sealed class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Table("Users");
            Id(x => x.ID);
            Map(x => x.UserName).Length(20).Not.Nullable();
            Map(x => x.Password).Length(20).Not.Nullable();
            Map(x => x.Email).Length(80).Not.Nullable();
            Map(x => x.IsDisabled).Not.Nullable();
            Map(x => x.DateRegistered).Not.Nullable();
            Map(x => x.DateLastLogon);
            Map(x => x.Contact).Length(4001);
            Map(x => x.PhoneNumber).Length(4001);
            Component(x => x.ContactAddress, m =>
            {
                m.Map(x => x.Country).Length(4001);
                m.Map(x => x.State).Length(4001);
                m.Map(x => x.City).Length(4001);
                m.Map(x => x.Street).Length(4001);
                m.Map(x => x.Zip).Length(4001);
            });
            Component(x => x.DeliveryAddress, m =>
            {
                m.Map(x => x.Country).Length(4001);
                m.Map(x => x.State).Length(4001);
                m.Map(x => x.City).Length(4001);
                m.Map(x => x.Street).Length(4001);
                m.Map(x => x.Zip).Length(4001);
            });
        }
    }
}