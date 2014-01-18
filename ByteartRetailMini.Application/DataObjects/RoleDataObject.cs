using System;

namespace ByteartRetailMini.Application.DataObjects
{
    [Serializable]
    public class RoleDataObject
    {
        public string ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}