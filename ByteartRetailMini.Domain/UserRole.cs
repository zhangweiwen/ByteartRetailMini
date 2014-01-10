using System;

namespace ByteartRetailMini.Domain
{
    public class UserRole : DomainObject
    {
        public virtual Guid UserID { get; set; }

        public virtual Guid RoleID { get; set; }
    }
}