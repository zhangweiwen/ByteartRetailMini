namespace ByteartRetailMini.Application.DataObjects
{
    public sealed class ProductDataObject
    {
        public string ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal? UnitPrice { get; set; }

        public string ImageUrl { get; set; }

        public bool? IsFeatured { get; set; }

        public CategoryDataObject Category { get; set; }
    }
}