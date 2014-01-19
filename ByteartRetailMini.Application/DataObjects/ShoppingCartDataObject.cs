using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ByteartRetailMini.Application.DataObjects
{
    [DataContract]
    public sealed class ShoppingCartDataObject
    {
        [DataMember]
        public string ID { get; set; }

        [DataMember]
        public string CustomerID { get; set; }

        [DataMember]
        public IList<ShoppingCartItemDataObject> Items { get; set; }

        [DataMember]
        public decimal? Subtotal { get; set; }
    }
}