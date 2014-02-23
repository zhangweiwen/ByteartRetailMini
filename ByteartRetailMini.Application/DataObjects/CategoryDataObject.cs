using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ByteartRetailMini.Application.DataObjects
{
    [DataContract]
    public sealed class CategoryDataObject
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public IList<ProductDataObject> Products { get; set; }
    }
}