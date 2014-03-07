using System.Runtime.Serialization;

namespace ByteartRetailMini.Infrastructure
{
    [DataContract]
    public class OrderInfo
    {
        [DataMember]
        public bool IsDesc { get; set; }

        [DataMember]
        public string OrderPropertyName { get; set; }
    }
}