using System.Runtime.Serialization;

namespace ByteartRetailMini.Application.DataObjects
{
    [DataContract]
    public class CategorizationDataObject
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string ProductID { get; set; }

        [DataMember]
        public string CategoryID { get; set; }
    }
}