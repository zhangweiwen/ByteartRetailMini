using System;
using System.Runtime.Serialization;

namespace ByteartRetailMini.Application.DataObjects
{
    [DataContract]
    public class UserDataObject
    {
        [DataMember]
        public string ID { get; set; }

        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public bool? IsDisabled { get; set; }

        [DataMember]
        public DateTime? DateRegistered { get; set; }

        [DataMember]
        public DateTime? DateLastLogon { get; set; }

        [DataMember]
        public RoleDataObject Role { get; set; }

        [DataMember]
        public string Contact { get; set; }

        [DataMember]
        public string PhoneNumber { get; set; }

        [DataMember]
        public AddressDataObject ContactAddress { get; set; }

        [DataMember]
        public AddressDataObject DeliveryAddress { get; set; }
    }
}