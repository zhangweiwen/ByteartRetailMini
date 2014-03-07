using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ByteartRetailMini.Infrastructure
{
    [DataContract]
    public class PagedList<T>
    {
        public PagedList()
        {
            
        }

        public PagedList(int pageSize, int totalCount)
        {
            PageSize = pageSize;
            TotalCount = totalCount;
            TotalPage = (TotalCount + PageSize - 1) / PageSize;
        }

        [DataMember]
        public int PageSize { get; set; }

        [DataMember]
        public int PageIndex { get; set; }

        [DataMember]
        public int TotalCount { get; set; }

        [DataMember]
        public int TotalPage { get; set; }

        [DataMember]
        public List<T> Items { get; set; }
    }
}