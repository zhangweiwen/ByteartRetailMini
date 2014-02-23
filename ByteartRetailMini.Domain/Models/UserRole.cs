using System;

namespace ByteartRetailMini.Domain.Models
{
    [Serializable]
    public class UserRole : DomainObject
    {
        public virtual int UserID { get; set; }

        public virtual int RoleID { get; set; }
    }
}