using System.Runtime.Serialization;

namespace ByteartRetailMini.Application.DataObjects
{
    [DataContract]
    public class RoleDataObject
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }
    }
}