using System.Runtime.Serialization;

namespace ByteartRetailMini.Infrastructure
{
    [DataContract]
    public class PageInfo
    {
        [DataMember]
        public int PageSize { get; set; }

        [DataMember]
        public int PageIndex { get; set; }

        [DataMember]
        public bool IsDesc { get; set; }

        [DataMember]
        public string OrderPropertyName { get; set; }
    }
}