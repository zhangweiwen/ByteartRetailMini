using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Activation;
using Autofac;
using ByteartRetailMini.Application;
using ByteartRetailMini.Application.DataObjects;
using ByteartRetailMini.Infrastructure;
using ByteartRetailMini.Services.Core;

namespace ByteartRetailMini.Services
{
    [IocServiceBehavior]
    [ServiceContract(Namespace = "zhww@outlook.com")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ProductService : BaseService
    {
        [OperationContract]
        public virtual IList<ProductDataObject> CreateProducts(IList<ProductDataObject> productDataObjects)
        {
            return ProductAppService.CreateProducts(productDataObjects);
        }

        [OperationContract]
        public virtual IList<CategoryDataObject> CreateCategories(IList<CategoryDataObject> categoryDataObjects)
        {
            return ProductAppService.CreateCategories(categoryDataObjects);
        }

        [OperationContract]
        public virtual IList<ProductDataObject> UpdateProducts(IList<ProductDataObject> productDataObjects)
        {
            return ProductAppService.UpdateProducts(productDataObjects);
        }

        [OperationContract]
        public virtual IList<CategoryDataObject> UpdateCategories(IList<CategoryDataObject> categoryDataObjects)
        {
            return ProductAppService.UpdateCategories(categoryDataObjects);
        }

        [OperationContract]
        public virtual void DeleteProducts(IList<int> productIDs)
        {
            ProductAppService.DeleteProducts(productIDs);
        }

        [OperationContract]
        public virtual void DeleteCategories(IList<int> categoryIDs)
        {
            ProductAppService.DeleteProducts(categoryIDs);
        }

        [OperationContract]
        public virtual CategorizationDataObject CategorizeProduct(int productID, int categoryID)
        {
            return ProductAppService.CategorizeProduct(productID, categoryID);
        }

        [OperationContract]
        public virtual void UncategorizeProduct(int productID)
        {
            ProductAppService.UncategorizeProduct(productID);
        }

        [OperationContract]
        public virtual CategoryDataObject GetCategoryByID(int id)
        {
            return ProductAppService.GetCategoryByID(id);
        }

        [OperationContract]
        public virtual IList<CategoryDataObject> GetCategories()
        {
            return ProductAppService.GetCategories();
        }

        [OperationContract]
        public virtual ProductDataObject GetProductByID(int id)
        {
            return ProductAppService.GetProductByID(id);
        }

        [OperationContract]
        public virtual IList<ProductDataObject> GetProducts()
        {
            return ProductAppService.GetProducts();
        }

        [OperationContract]
        public virtual PagedList<ProductDataObject> GetProductsWithPagination(PageInfo pageInfo)
        {
            return ProductAppService.GetProductsWithPagination(pageInfo);
        }

        [OperationContract]
        public virtual IList<ProductDataObject> GetProductsForCategory(int categoryID)
        {
            return ProductAppService.GetProductsForCategory(categoryID);
        }

        [OperationContract]
        public virtual PagedList<ProductDataObject> GetProductsForCategoryWithPagination(int categoryID, PageInfo pageInfo)
        {
            return ProductAppService.GetProductsForCategoryWithPagination(categoryID, pageInfo);
        }

        [OperationContract]
        public virtual IList<ProductDataObject> GetFeaturedProducts(int count)
        {
            return ProductAppService.GetFeaturedProducts(count);
        }
    }
}