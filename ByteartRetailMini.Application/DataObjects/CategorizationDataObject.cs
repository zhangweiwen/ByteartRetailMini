using System;

namespace ByteartRetailMini.Application.DataObjects
{
    [Serializable]
    public class CategorizationDataObject
    {
        public string ID { get; set; }

        public string ProductID { get; set; }

        public string CategoryID { get; set; }
    }
}