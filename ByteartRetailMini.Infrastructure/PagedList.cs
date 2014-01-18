using System;
using System.Collections.Generic;

namespace ByteartRetailMini.Infrastructure
{
    [Serializable]
    public class PagedList<T>
    {
        public int PageSize { get; set; }

        public int PageIndex { get; set; }

        public int? TotalCount { get; set; }

        public int? TotalPage
        {
            get
            {
                return TotalCount + PageSize - 1 / PageSize;
            }
        }

        public IList<T> Items { get; set; }
    }
}