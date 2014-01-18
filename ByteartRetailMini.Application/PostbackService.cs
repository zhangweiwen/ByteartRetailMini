using System;
using ByteartRetailMini.Application.DataObjects;

namespace ByteartRetailMini.Application
{
    public class PostbackService : IPostbackService
    {
        public PostbackDataObject GetPostback()
        {
            const string formater = @"{0} processors on {1} bit OS.";
            var bit = Environment.Is64BitOperatingSystem ? "64" : "32";
            var sa = string.Format(formater, Environment.ProcessorCount, bit);
            return new PostbackDataObject
            {
                ID = Guid.NewGuid().ToString(),
                ServerArchitecture = sa,
                ServerDateTime = DateTime.Now,
                ServerOS = Environment.OSVersion.ToString(),
                MachineName = Environment.MachineName,
                CLRVersion = Environment.Version.ToString()
            };
        }
    }
}