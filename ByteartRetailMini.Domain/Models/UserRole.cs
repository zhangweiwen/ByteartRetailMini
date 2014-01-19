using System;

namespace ByteartRetailMini.Domain.Models
{
    [Serializable]
    public class UserRole : DomainObject
    {
        public virtual Guid UserID { get; set; }

        public virtual Guid RoleID { get; set; }
    }
}