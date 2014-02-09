using System;
using System.Collections.Generic;

namespace ByteartRetailMini.Web.IViews.Home
{
    public partial interface IIndex
    {
        event Action PageLoad;
    }

    public partial interface IIndex
    {
        void BindFeaturedProducts(List<Services.ProductDataObject> products);
    }
}