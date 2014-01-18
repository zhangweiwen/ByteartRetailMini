using System.Collections.Generic;

namespace ByteartRetailMini.Application.DataObjects
{
    public sealed class CategoryDataObject
    {
        public string ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public IList<ProductDataObject> Products { get; set; }
    }
}