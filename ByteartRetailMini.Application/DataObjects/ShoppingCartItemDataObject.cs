using System.Runtime.Serialization;

namespace ByteartRetailMini.Application.DataObjects
{
    [DataContract]
    public sealed class ShoppingCartItemDataObject
    {
        [DataMember]
        public string ID { get; set; }

        [DataMember]
        public int? Quantity { get; set; }

        [DataMember]
        public ProductDataObject Product { get; set; }

        [DataMember]
        public decimal? LineAmount { get; set; }

        [DataMember]
        public string ShoppingCartID { get; set; }
    }
}