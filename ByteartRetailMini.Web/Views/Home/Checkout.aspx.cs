using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ByteartRetailMini.Web.Core;
using ByteartRetailMini.Web.Services;

namespace ByteartRetailMini.Web.Views.Home
{
    public partial class Checkout : AuthorizePage
    {
        public OrderService OrderService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            var userName = User.Identity.Name;
            if (string.IsNullOrWhiteSpace(userName) == false)
            {
                var salesOrder = OrderService.Checkout(userName);
                if (salesOrder == null)
                {
                    Response.Redirect("/Home/Index");
                    return;
                }
                BindSalesOrder(salesOrder);
            }
            //BindSalesOrder(new SalesOrderDataObject
            //{
            //    CustomerAddressCity = "123",
            //    CustomerAddressCountry = "123",
            //    Status = SalesOrderStatus.Created,
            //    CustomerAddressState = "123",
            //    CustomerAddressStreet = "123",
            //    CustomerAddressZip = "123",
            //    CustomerContact = "123",
            //    ExtensionData = null,
            //    CustomerEmail = "1q23",
            //    CustomerID = "123",
            //    CustomerName = "123",
            //    CustomerPhone = "123",
            //    DateCreated =DateTime.Now,
            //    ID = 1,
            //    DateDelivered = DateTime.Now,
            //    DateDispatched = DateTime.Now,
            //    SalesLines = new List<SalesLineDataObject>(),
            //    Subtotal = 100,
            //});
        }

        private void BindSalesOrder(SalesOrderDataObject salesOrder)
        {
            UserId.InnerText = salesOrder.CustomerID;
            ZipAndStreet.InnerText = string.Format("{0}, {1}", salesOrder.CustomerAddressZip,
                salesOrder.CustomerAddressStreet);
            CityAndStateAndCountry.InnerText = string.Format("{0}, {1}, {2}", salesOrder.CustomerAddressCity,
                salesOrder.CustomerAddressState, salesOrder.CustomerAddressCountry);
            CustomerContact.InnerText = salesOrder.CustomerContact;
            CustomerPhone.InnerText = salesOrder.CustomerPhone;
            CustomerEmail.InnerText = salesOrder.CustomerEmail;
            SalesOrderLink.HRef = string.Format("/Home/SalesOrder?id={0}", salesOrder.ID);
        }
    }
}