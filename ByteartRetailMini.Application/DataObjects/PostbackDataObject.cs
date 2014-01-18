using System;

namespace ByteartRetailMini.Application.DataObjects
{
    public class PostbackDataObject
    {
        public string ID { get; set; }
        
        public string ServerOS { get; set; }

        public string CLRVersion { get; set; }

        public string MachineName { get; set; }

        public DateTime ServerDateTime { get; set; }

        public string ServerArchitecture { get; set; }
    }
}