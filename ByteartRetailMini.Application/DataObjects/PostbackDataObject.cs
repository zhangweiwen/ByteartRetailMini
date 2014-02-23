using System;
using System.Runtime.Serialization;

namespace ByteartRetailMini.Application.DataObjects
{
    [DataContract]
    public class PostbackDataObject
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string ServerOS { get; set; }

        [DataMember]
        public string CLRVersion { get; set; }

        [DataMember]
        public string MachineName { get; set; }

        [DataMember]
        public DateTime ServerDateTime { get; set; }

        [DataMember]
        public string ServerArchitecture { get; set; }
    }
}