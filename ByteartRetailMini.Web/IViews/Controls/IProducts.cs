using System;
using ByteartRetailMini.Web.Services;

namespace ByteartRetailMini.Web.IViews.Controls
{
    public partial interface IProducts
    {
        event Action<int, int> PageLoad;
    }

    public partial interface IProducts
    {
        void ShowNotFound();
        void BindCategory(string categoryName);
        void BindProducts(PagedListOfProductDataObjectUqqArW2s products);
        void BindPageInfo(int categoryID, PagedListOfProductDataObjectUqqArW2s products);
    }
}