using System;
using System.Collections.Generic;
using System.Linq;
using ByteartRetailMini.Application.DataObjects;
using ByteartRetailMini.Domain.Models;
using ByteartRetailMini.Domain.Services;
using ByteartRetailMini.Infrastructure;
using NHibernate;
using NHibernate.Linq;
using System.Linq.Dynamic;

namespace ByteartRetailMini.Application
{
    public class ProductService : IProductService
    {
        private readonly ISession _session;
        private readonly IDomainService _domainService;

        public ProductService(ISession session, IDomainService domainService)
        {
            if (session == null)
                throw new ArgumentNullException("session");

            if (domainService == null)
                throw new ArgumentNullException("domainService");

            _session = session;
            _domainService = domainService;
        }

        public IList<ProductDataObject> CreateProducts(IList<ProductDataObject> productDataObjects)
        {
            var results = new List<ProductDataObject>();
            foreach (var item in productDataObjects)
            {
                var domain = item.ToDomain();
                _session.Save(domain);
                results.Add(domain.ToData());
            }
            return results;
        }

        public IList<CategoryDataObject> CreateCategories(IList<CategoryDataObject> categoryDataObjects)
        {
            var results = new List<CategoryDataObject>();
            foreach (var item in categoryDataObjects)
            {
                var domain = item.ToDomain();
                _session.Save(domain);
                results.Add(domain.ToData());
            }
            return results;
        }

        public IList<ProductDataObject> UpdateProducts(IList<ProductDataObject> productDataObjects)
        {
            var results = new List<ProductDataObject>();
            foreach (var item in productDataObjects)
            {
                var dbValue = _session.Get<Product>(item.ID);
                if (string.IsNullOrWhiteSpace(item.Description) == false)
                    dbValue.Description = item.Description;

                if (string.IsNullOrWhiteSpace(item.ImageUrl) == false)
                    dbValue.ImageUrl = item.ImageUrl;

                if (string.IsNullOrWhiteSpace(item.Name) == false)
                    dbValue.Name = item.Name;

                if (item.IsFeatured != null)
                    dbValue.IsFeatured = item.IsFeatured.Value;

                if (item.UnitPrice != null)
                    dbValue.UnitPrice = item.UnitPrice.Value;

                results.Add(dbValue.ToData());
            }
            return results;
        }

        public IList<CategoryDataObject> UpdateCategories(IList<CategoryDataObject> categoryDataObjects)
        {
            var results = new List<CategoryDataObject>();
            foreach (var item in categoryDataObjects)
            {
                var dbValue = _session.Get<Category>(item.ID);
                if (!string.IsNullOrEmpty(item.Name))
                    dbValue.Name = item.Name;

                if (!string.IsNullOrEmpty(item.Description))
                    dbValue.Description = item.Description;

                results.Add(dbValue.ToData());
            }
            return results;
        }

        public void DeleteProducts(IList<int> productIDs)
        {
            foreach (var id in productIDs)
            {
                _session.Delete(new Product { ID = id });
            }
        }

        public void DeleteCategories(IList<int> categoryIDs)
        {
            foreach (var id in categoryIDs)
            {
                _session.Delete(new Category { ID = id });
            }
        }

        public CategorizationDataObject CategorizeProduct(int productID, int categoryID)
        {
            var product = _session.Get<Product>(productID);
            var category = _session.Get<Category>(categoryID);
            var categorization = _domainService.Categorize(product, category);
            return categorization.ToData();
        }

        public void UncategorizeProduct(int productID)
        {
            var product = _session.Get<Product>(productID);
            _domainService.Uncategorize(product);
        }

        public CategoryDataObject GetCategoryByID(int id)
        {
            return _session.Get<Category>(id).ToData();
        }

        public IList<CategoryDataObject> GetCategories()
        {
            return _session.Query<Category>().ToList().Select(c => c.ToData()).ToList();
        }

        public Category GetCategoryForProduct(int productID)
        {
            var query = _session.Query<Category>()
                .Join(_session.Query<Categorization>(), x => x.ID, y => y.CategoryID, (x, y) => new {x, y})
                .Where(o => o.y.ProductID == productID).Select(x => x.x);
            return query.FirstOrDefault();
        }

        public ProductDataObject GetProductByID(int id)
        {
            var product = _session.Get<Product>(id).ToData();
            product.Category = GetCategoryForProduct(id).ToData();
            return product;
        }

        public IList<ProductDataObject> GetProducts()
        {
            return _session.Query<Product>().ToList().Select(c => c.ToData()).ToList();
        }

        public PagedList<ProductDataObject> GetProductsWithPagination(PageInfo pageInfo)
        {
            var products = _session.Query<Product>().ToPagedList(pageInfo).Select(p => p.ToData()).ToList();
            return new PagedList<ProductDataObject>(pageInfo.PageSize, _session.Query<Product>().Count())
            {
                PageIndex = pageInfo.PageIndex,
                Items = products
            };
        }

        public IList<ProductDataObject> GetProductsForCategory(int categoryID)
        {
            return _session.Query<Product>()
                .Join(_session.Query<Categorization>(), p => p.ID, c => c.ProductID, (p, c) => new { p, c })
                .Where(x => x.c.CategoryID == categoryID)
                .Select(x => x.p.ToData()).ToList();
        }

        public PagedList<ProductDataObject> GetProductsForCategoryWithPagination(int categoryID, PageInfo pageInfo)
        {
            var query = _session.Query<Product>()
                .Join(_session.Query<Categorization>(), p => p.ID, c => c.ProductID, (p, c) => new { p, c })
                .Where(x => x.c.CategoryID == categoryID);
            var products = query.ToPagedList(pageInfo).Select(x => x.p.ToData()).ToList();
            return new PagedList<ProductDataObject>(pageInfo.PageSize, query.Count())
            {
                PageIndex = pageInfo.PageIndex,
                Items = products
            };
        }

        public IList<ProductDataObject> GetFeaturedProducts(int count)
        {
            var query = _session.Query<Product>().Where(p => p.IsFeatured);
            if (count > 0)
                query = query.Take(count);

            var result = query.Select(p => p.ToData()).ToList();
            return result;
        }
    }
}