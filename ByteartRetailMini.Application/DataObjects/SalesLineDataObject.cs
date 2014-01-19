using System;
using System.Runtime.Serialization;

namespace ByteartRetailMini.Application.DataObjects
{
    [DataContract]
    public class SalesLineDataObject
    {
        [DataMember]
        public string ID { get; set; }

        [DataMember]
        public int? Quantity { get; set; }

        [DataMember]
        public string SalesOrderID { get; set; }

        [DataMember]
        public ProductDataObject Product { get; set; }

        [DataMember]
        public decimal? LineAmount { get; set; }
    }
}