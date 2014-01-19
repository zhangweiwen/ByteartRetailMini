﻿using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Activation;
using ByteartRetailMini.Application;
using ByteartRetailMini.Application.DataObjects;
using ByteartRetailMini.Infrastructure;

namespace ByteartRetailMini.Services
{
    [ServiceContract(Namespace = "zhww@outlook.com")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ProductService
    {
        public IProductService ProductAppService { get; set; }

        [OperationContract]
        public IList<ProductDataObject> CreateProducts(IList<ProductDataObject> productDataObjects)
        {
            return ProductAppService.CreateProducts(productDataObjects);
        }

        [OperationContract]
        public IList<CategoryDataObject> CreateCategories(IList<CategoryDataObject> categoryDataObjects)
        {
            return ProductAppService.CreateCategories(categoryDataObjects);
        }

        [OperationContract]
        public IList<ProductDataObject> UpdateProducts(IList<ProductDataObject> productDataObjects)
        {
            return ProductAppService.UpdateProducts(productDataObjects);
        }

        [OperationContract]
        public IList<CategoryDataObject> UpdateCategories(IList<CategoryDataObject> categoryDataObjects)
        {
            return ProductAppService.UpdateCategories(categoryDataObjects);
        }

        [OperationContract]
        public void DeleteProducts(IList<string> productIDs)
        {
            ProductAppService.DeleteProducts(productIDs);
        }

        [OperationContract]
        public void DeleteCategories(IList<string> categoryIDs)
        {
            ProductAppService.DeleteProducts(categoryIDs);
        }

        [OperationContract]
        public CategorizationDataObject CategorizeProduct(Guid productID, Guid categoryID)
        {
            return ProductAppService.CategorizeProduct(productID, categoryID);
        }

        [OperationContract]
        public void UncategorizeProduct(Guid productID)
        {
            ProductAppService.UncategorizeProduct(productID);
        }

        [OperationContract]
        public CategoryDataObject GetCategoryByID(Guid id)
        {
            return ProductAppService.GetCategoryByID(id);
        }

        [OperationContract]
        public IList<CategoryDataObject> GetCategories()
        {
            return ProductAppService.GetCategories();
        }

        [OperationContract]
        public ProductDataObject GetProductByID(Guid id)
        {
            return ProductAppService.GetProductByID(id);
        }

        [OperationContract]
        public IList<ProductDataObject> GetProducts()
        {
            return ProductAppService.GetProducts();
        }

        [OperationContract]
        public PagedList<ProductDataObject> GetProductsWithPagination(PageInfo pageInfo)
        {
            return ProductAppService.GetProductsWithPagination(pageInfo);
        }

        [OperationContract]
        public IList<ProductDataObject> GetProductsForCategory(Guid categoryID)
        {
            return ProductAppService.GetProductsForCategory(categoryID);
        }

        [OperationContract]
        public PagedList<ProductDataObject> GetProductsForCategoryWithPagination(Guid categoryID, PageInfo pageInfo)
        {
            return ProductAppService.GetProductsForCategoryWithPagination(categoryID, pageInfo);
        }

        [OperationContract]
        public IList<ProductDataObject> GetFeaturedProducts(int count)
        {
            return ProductAppService.GetFeaturedProducts(count);
        }
    }
}