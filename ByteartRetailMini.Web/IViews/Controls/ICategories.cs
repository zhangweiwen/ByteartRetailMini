using System;
using System.Collections.Generic;
using ByteartRetailMini.Web.Services;

namespace ByteartRetailMini.Web.IViews.Controls
{
    public partial interface ICategories
    {
        event Action PageLoad;
    }

    public partial interface ICategories
    {
        void BindCategories(IList<CategoryDataObject> categories);
    }
}