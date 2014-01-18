namespace ByteartRetailMini.Application.DataObjects
{
    public class SalesLineDataObject
    {
        public string ID { get; set; }

        public int? Quantity { get; set; }

        public string SalesOrderID { get; set; }

        public ProductDataObject Product { get; set; }

        public decimal? LineAmount { get; set; }
    }
}