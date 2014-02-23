using System;
using System.Globalization;
using System.Web.UI;
using ByteartRetailMini.Web.Services;

namespace ByteartRetailMini.Web.Views.Home
{
    public partial class Product : Page
    {
        public ProductService ProductService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            int id;
            int.TryParse(Request.QueryString["id"], out id);
            if (id > 0)
            {
                var product = ProductService.GetProductByID(id);
                BindData(product);
            }
        }

        private void BindData(ProductDataObject product)
        {
            ProductImg.Src = string.Format("/Images/Products/{0}", product.ImageUrl);
            ProductNameH2.InnerText = product.Name;
            CategoryNameSpan.InnerText = product.Category.Name;
            ProductDescriptionTd.InnerText = product.Description;
            PriceTd.InnerText = string.Format("{0:N2} 元", product.UnitPrice);
            ProductIdInput.Value = product.ID.ToString(CultureInfo.InvariantCulture);
        }
    }
}