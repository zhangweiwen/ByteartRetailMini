using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ByteartRetailMini.Application.DataObjects
{
    [Serializable]
    public class UserDataObject
    {
        public string ID { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public bool? IsDisabled { get; set; }

        public DateTime? DateRegistered { get; set; }

        public DateTime? DateLastLogon { get; set; }

        public RoleDataObject Role { get; set; }

        public string Contact { get; set; }

        public string PhoneNumber { get; set; }

        public AddressDataObject ContactAddress { get; set; }

        public AddressDataObject DeliveryAddress { get; set; }
    }
}