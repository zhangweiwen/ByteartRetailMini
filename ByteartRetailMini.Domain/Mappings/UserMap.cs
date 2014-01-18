using ByteartRetailMini.Domain.Models;
using FluentNHibernate.Mapping;

namespace ByteartRetailMini.Domain.Mappings
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
                m.Map(x => x.Country, "ContactAddress_Country").Length(4001);
                m.Map(x => x.State, "ContactAddress_State").Length(4001);
                m.Map(x => x.City, "ContactAddress_City").Length(4001);
                m.Map(x => x.Street, "ContactAddress_Street").Length(4001);
                m.Map(x => x.Zip, "ContactAddress_Zip").Length(4001);
            });
            Component(x => x.DeliveryAddress, m =>
            {
                m.Map(x => x.Country, "DeliveryAddress_Country").Length(4001);
                m.Map(x => x.State, "DeliveryAddress_State").Length(4001);
                m.Map(x => x.City, "DeliveryAddress_City").Length(4001);
                m.Map(x => x.Street, "DeliveryAddress_Street").Length(4001);
                m.Map(x => x.Zip, "DeliveryAddress_Zip").Length(4001);
            });
        }
    }
}