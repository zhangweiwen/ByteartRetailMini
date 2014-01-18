using System;
using System.Collections.Generic;
using ByteartRetailMini.Domain.Models;

namespace ByteartRetailMini.Application.DataObjects
{
    public class SalesOrderDataObject
    {
        public string ID { get; set; }

        public SalesOrderStatus? Status { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateDispatched { get; set; }

        public DateTime? DateDelivered { get; set; }

        public string CustomerID { get; set; }

        public string CustomerName { get; set; }

        public string CustomerContact { get; set; }

        public string CustomerPhone { get; set; }

        public string CustomerEmail { get; set; }

        public string CustomerAddressCountry { get; set; }

        public string CustomerAddressState { get; set; }

        public string CustomerAddressCity { get; set; }

        public string CustomerAddressStreet { get; set; }

        public string CustomerAddressZip { get; set; }

        public IList<SalesLineDataObject> SalesLines { get; set; }

        public decimal? Subtotal { get; set; }
    }
}