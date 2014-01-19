using System;

namespace ByteartRetailMini.Web.Core
{
    [Flags]
    public enum Role
    {
        None = 0,
        Customers = 1,
        SalesReps = 2,
        Buyers = 4,
        Administrators = 8
    }
}