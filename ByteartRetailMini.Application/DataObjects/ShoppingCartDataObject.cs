using System.Collections.Generic;

namespace ByteartRetailMini.Application.DataObjects
{
    public sealed class ShoppingCartDataObject
    {
        public string ID { get; set; }

        public string CustomerID { get; set; }

        public IList<ShoppingCartItemDataObject> Items { get; set; }

        public decimal? Subtotal { get; set; }
    }
}