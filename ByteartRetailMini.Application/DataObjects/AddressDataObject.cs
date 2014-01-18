using System;

namespace ByteartRetailMini.Application.DataObjects
{
    [Serializable]
    public class AddressDataObject
    {
        public string Country { get; set; }

        public string State { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string Zip { get; set; }
    }
}