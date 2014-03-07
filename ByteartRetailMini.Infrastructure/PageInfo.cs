using System.Collections.Generic;
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
        public IList<OrderInfo> OrderInfos { get; set; }
    }
}