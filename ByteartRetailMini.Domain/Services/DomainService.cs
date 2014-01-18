using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using ByteartRetailMini.Domain.Models;
using NHibernate;
using NHibernate.Linq;

namespace ByteartRetailMini.Domain.Services
{
    public class DomainService : IDomainService
    {
        private readonly ISession _session;

        public DomainService(ISession session)
        {
            if (session == null)
                throw new ArgumentNullException("session");

            _session = session;
        }

        public Categorization Categorize(Product product, Category category)
        {
            if (product == null)
                throw new ArgumentNullException("product");

            if (category == null)
                throw new ArgumentNullException("category");

            var categorization = _session.Query<Categorization>().FirstOrDefault(c => c.ProductID == product.ID);
            if (categorization == null)
            {
                categorization = Categorization.CreateCategorization(product, category);
                _session.Save(categorization);
            }
            else
            {
                categorization.CategoryID = category.ID;
                _session.Update(categorization);
            }
            return categorization;
        }

        public void Uncategorize(Product product, Category category = null)
        {
            Expression<Func<Categorization, bool>> specExpression;
            if (category == null)
            {
                var p1 = product;
                specExpression = p => p.ProductID == p1.ID;
            }
            else
            {
                var p1 = product;
                var c1 = category;
                specExpression = p => p.ProductID == p1.ID && p.CategoryID == c1.ID;
            }
            var categorization = _session.Query<Categorization>().FirstOrDefault(specExpression);
            if (categorization != null)
            {
                _session.Delete(categorization);
            }
        }

        public SalesOrder CreateSalesOrder(User user, ShoppingCart shoppingCart)
        {
            var shoppingCartItems = _session.Query<ShoppingCartItem>()
                .Where(i => i.ShoppingCart.ID == shoppingCart.ID).ToList();

            if (shoppingCartItems == null || shoppingCartItems.Any() == false)
                throw new InvalidOperationException("购物篮中没有任何物品。");

            var salesOrder = new SalesOrder { SalesLines = new List<SalesLine>() };
            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var salesLine = shoppingCartItem.ConvertToSalesLine();
                salesLine.SalesOrder = salesOrder;
                salesOrder.SalesLines.Add(salesLine);
                _session.Delete(shoppingCartItem);
            }
            salesOrder.User = user;
            salesOrder.Status = SalesOrderStatus.Paid;
            _session.Save(salesOrder);
            return salesOrder;
        }

        public UserRole AssignRole(User user, Role role)
        {
            if (user == null)
                throw new ArgumentNullException("user");
            if (role == null)
                throw new ArgumentNullException("role");

            var userRole = _session.Query<UserRole>().FirstOrDefault(ur => ur.UserID == user.ID);
            if (userRole == null)
            {
                userRole = new UserRole
                {
                    ID = Guid.NewGuid(),
                    RoleID = role.ID,
                    UserID = user.ID
                };
                _session.Save(userRole);
            }
            else
            {
                userRole.RoleID = role.ID;
                _session.Update(userRole);
            }
            return userRole;
        }

        public void UnassignRole(User user, Role role = null)
        {
            if (user == null)
                throw new ArgumentNullException("user");

            Expression<Func<UserRole, bool>> specExpression;
            if (role == null)
            {
                var u1 = user;
                specExpression = ur => ur.UserID == u1.ID;
            }
            else
            {
                var u1 = user;
                var r1 = role;
                specExpression = ur => ur.UserID == u1.ID && ur.RoleID == r1.ID;
            }
            var userRole = _session.Query<UserRole>().FirstOrDefault(specExpression);
            if (userRole != null)
            {
                _session.Delete(userRole);
            }
        }
    }
}