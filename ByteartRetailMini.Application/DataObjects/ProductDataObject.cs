using System.Runtime.Serialization;

namespace ByteartRetailMini.Application.DataObjects
{
    [DataContract]
    public sealed class ProductDataObject
    {
        [DataMember]
        public string ID { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public decimal? UnitPrice { get; set; }

        [DataMember]
        public string ImageUrl { get; set; }

        [DataMember]
        public bool? IsFeatured { get; set; }

        [DataMember]
        public CategoryDataObject Category { get; set; }
    }
}