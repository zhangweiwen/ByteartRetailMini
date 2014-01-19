using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using ByteartRetailMini.Domain.Models;

namespace ByteartRetailMini.Application.DataObjects
{
    [DataContract]
    public class SalesOrderDataObject
    {
        [DataMember]
        public string ID { get; set; }

        [DataMember]
        public SalesOrderStatus? Status { get; set; }

        [DataMember]
        public DateTime? DateCreated { get; set; }

        [DataMember]
        public DateTime? DateDispatched { get; set; }

        [DataMember]
        public DateTime? DateDelivered { get; set; }

        [DataMember]
        public string CustomerID { get; set; }

        [DataMember]
        public string CustomerName { get; set; }

        [DataMember]
        public string CustomerContact { get; set; }

        [DataMember]
        public string CustomerPhone { get; set; }

        [DataMember]
        public string CustomerEmail { get; set; }

        [DataMember]
        public string CustomerAddressCountry { get; set; }

        [DataMember]
        public string CustomerAddressState { get; set; }

        [DataMember]
        public string CustomerAddressCity { get; set; }

        [DataMember]
        public string CustomerAddressStreet { get; set; }

        [DataMember]
        public string CustomerAddressZip { get; set; }

        [DataMember]
        public IList<SalesLineDataObject> SalesLines { get; set; }

        [DataMember]
        public decimal? Subtotal { get; set; }
    }
}