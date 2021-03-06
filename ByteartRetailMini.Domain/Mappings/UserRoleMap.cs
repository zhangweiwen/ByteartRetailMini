﻿using ByteartRetailMini.Domain.Models;
using FluentNHibernate.Mapping;

namespace ByteartRetailMini.Domain.Mappings
{
    public sealed class UserRoleMap : ClassMap<UserRole>
    {
        public UserRoleMap()
        {
            Table("UserRoles");
            Id(x => x.ID);
            Map(x => x.RoleID).Not.Nullable();
            Map(x => x.UserID).Not.Nullable();
        }
    }
}