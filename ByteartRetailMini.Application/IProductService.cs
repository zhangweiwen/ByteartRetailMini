using System;
using System.Collections.Generic;
using ByteartRetailMini.Application.DataObjects;
using ByteartRetailMini.Infrastructure;

namespace ByteartRetailMini.Application
{
    public interface IProductService
    {
        /// <summary>
        /// 创建商品信息。
        /// </summary>
        /// <param name="productDataObjects">需要创建的商品信息。</param>
        /// <returns>已创建的商品信息。</returns>
        IList<ProductDataObject> CreateProducts(IList<ProductDataObject> productDataObjects);
        
        /// <summary>
        /// 创建商品分类。
        /// </summary>
        /// <param name="categoryDataObjects">需要创建的商品分类。</param>
        /// <returns>已创建的商品分类。</returns>
        IList<CategoryDataObject> CreateCategories(IList<CategoryDataObject> categoryDataObjects);

        /// <summary>
        /// 更新商品信息。
        /// </summary>
        /// <param name="productDataObjects">需要更新的商品信息。</param>
        /// <returns>已更新的商品信息。</returns>
        IList<ProductDataObject> UpdateProducts(IList<ProductDataObject> productDataObjects);
        
        /// <summary>
        /// 更新商品分类。
        /// </summary>
        /// <param name="categoryDataObjects">需要更新的商品分类。</param>
        /// <returns>已更新的商品分类。</returns>
        IList<CategoryDataObject> UpdateCategories(IList<CategoryDataObject> categoryDataObjects);
        
        /// <summary>
        /// 删除商品信息。
        /// </summary>
        /// <param name="productIDs">需要删除的商品信息的ID值。</param>
        void DeleteProducts(IList<string> productIDs);
        
        /// <summary>
        /// 删除商品分类。
        /// </summary>
        /// <param name="categoryIDs">需要删除的商品分类的ID值。</param>
        void DeleteCategories(IList<string> categoryIDs);
        
        /// <summary>
        /// 设置商品分类。
        /// </summary>
        /// <param name="productID">需要进行分类的商品ID值。</param>
        /// <param name="categoryID">商品分类ID值。</param>
        /// <returns>带有商品分类信息的对象。</returns>
        CategorizationDataObject CategorizeProduct(Guid productID, Guid categoryID);
        
        /// <summary>
        /// 取消商品分类。
        /// </summary>
        /// <param name="productID">需要取消分类的商品ID值。</param>
        void UncategorizeProduct(Guid productID);

        /// <summary>
        /// 根据指定的ID值获取商品分类。
        /// </summary>
        /// <param name="id">商品分类ID值。</param>
        /// <returns>商品分类。</returns>
        CategoryDataObject GetCategoryByID(Guid id);
        
        /// <summary>
        /// 获取所有的商品分类。
        /// </summary>
        /// <returns>所有的商品分类。</returns>
        IList<CategoryDataObject> GetCategories();
        
        /// <summary>
        /// 根据指定的ID值获取商品信息。
        /// </summary>
        /// <param name="id">商品信息ID值。</param>
        /// <returns>商品信息。</returns>
        ProductDataObject GetProductByID(Guid id);
        
        /// <summary>
        /// 获取所有的商品信息。
        /// </summary>
        /// <returns>商品信息。</returns>
        IList<ProductDataObject> GetProducts();

        /// <summary>
        /// 以分页的方式获取所有商品信息。
        /// </summary>
        /// <param name="pageInfo">带有分页参数信息的对象。</param>
        /// <returns>经过分页的商品信息。</returns>
        PagedList<ProductDataObject> GetProductsWithPagination(PageInfo pageInfo);
        
        /// <summary>
        /// 根据指定的商品分类ID值，获取该分类下所有的商品信息。
        /// </summary>
        /// <param name="categoryID">商品分类ID值。</param>
        /// <returns>所有的商品信息。</returns>
        IList<ProductDataObject> GetProductsForCategory(Guid categoryID);

        /// <summary>
        /// 根据指定的商品分类ID值，以分页的方式获取该分类下所有的商品信息。
        /// </summary>
        /// <param name="categoryID">商品分类ID值。</param>
        /// <param name="pageInfo">带有分页参数信息的对象。</param>
        /// <returns>所有的商品信息。</returns>
        PagedList<ProductDataObject> GetProductsForCategoryWithPagination(Guid categoryID, PageInfo pageInfo);
        
        /// <summary>
        /// 获取所有的特色商品信息。
        /// </summary>
        /// <param name="count">需要获取的特色商品信息的个数。</param>
        /// <returns>特色商品信息。</returns>
        IList<ProductDataObject> GetFeaturedProducts(int count);
    }
}