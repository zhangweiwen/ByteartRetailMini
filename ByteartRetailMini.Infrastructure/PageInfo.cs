using System;

namespace ByteartRetailMini.Infrastructure
{
    [Serializable]
    public class PageInfo
    {
        public int PageSize { get; set; }

        public int PageIndex { get; set; }

        public bool IsDesc { get; set; }

        public string OrderPropertyName { get; set; }
    }
}