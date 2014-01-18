namespace ByteartRetailMini.Application.DataObjects
{
    public sealed class ShoppingCartItemDataObject
    {
        public string ID { get; set; }

        public int? Quantity { get; set; }

        public ProductDataObject Product { get; set; }

        public decimal? LineAmount { get; set; }

        public string ShoppingCartID { get; set; }
    }
}