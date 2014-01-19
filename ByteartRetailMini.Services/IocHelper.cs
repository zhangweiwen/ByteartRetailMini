using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;

namespace ByteartRetailMini.Services
{
    public class IocHelper
    {
        internal static IContainer Container { get; private set; }
    }
}