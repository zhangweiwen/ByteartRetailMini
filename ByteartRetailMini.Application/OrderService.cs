using System;
using System.Collections.Generic;
using System.Linq;
using ByteartRetailMini.Application.DataObjects;
using ByteartRetailMini.Domain.Models;
using ByteartRetailMini.Domain.Services;
using NHibernate;
using NHibernate.Linq;

namespace ByteartRetailMini.Application
{
    public class OrderService : IOrderService
    {
        private readonly ISession _session;
        private readonly IDomainService _domainService;

        public OrderService(ISession session,IDomainService domainService)
        {
            if (session == null)
                throw new ArgumentNullException("session");

            if (session == null)
                throw new ArgumentNullException("domainService");

            _session = session;
            _domainService = domainService;
        }

        public int GetShoppingCartItemCount(Guid userID)
        {
            var shoppingCart = _session.Query<ShoppingCart>().FirstOrDefault(s => s.User.ID == userID);
            if (shoppingCart == null)
                throw new InvalidOperationException("没有可用的购物车实例。");

            var shoppingCartItems = _session.Query<ShoppingCartItem>()
                .Where(s => s.ShoppingCart.ID == shoppingCart.ID).ToList();
            return shoppingCartItems.Sum(s => s.Quantity);
        }

        /// <summary>
        /// 将指定的商品添加到指定客户的购物篮里。
        /// </summary>
        /// <param name="userID">用于指代特定客户对象的全局唯一标识。</param>
        /// <param name="productID">用于指代特定商品对象的全局唯一标识。</param>
        /// <param name="quantity">数量</param>
        public void AddProductToCart(Guid userID, Guid productID, int quantity)
        {
            var shoppingCart = _session.Query<ShoppingCart>().FirstOrDefault(s => s.User.ID == userID);
            if (shoppingCart == null)
            {
                var msg = string.Format("Shopping cart doesn't exist for customer {0}.", userID);
                throw new InvalidOperationException(msg);
            }
            var product = _session.Get<Product>(productID);
            var shoppingCartItem = _session.Query<ShoppingCartItem>()
                .FirstOrDefault(s => s.ShoppingCart.ID == shoppingCart.ID && s.Product.ID == product.ID);
            if (shoppingCartItem != null)
            {
                shoppingCartItem.UpdateQuantity(shoppingCartItem.Quantity + quantity);
                return;
            }
            shoppingCartItem = new ShoppingCartItem
            {
                ID = Guid.NewGuid(),
                Product = product,
                ShoppingCart = shoppingCart,
                Quantity = quantity
            };
            _session.Save(shoppingCartItem);
        }

        /// <summary>
        /// 根据指定客户对象的全局唯一标识，获取该客户的购物篮信息。
        /// </summary>
        /// <param name="userID">用于指代特定客户对象的全局唯一标识。</param>
        /// <returns>包含了购物篮信息的数据传输对象。</returns>
        public ShoppingCartDataObject GetShoppingCart(Guid userID)
        {
            var shoppingCart = _session.Query<ShoppingCart>().FirstOrDefault(s => s.User.ID == userID);
            if (shoppingCart == null)
            {
                var msg = string.Format("Customer ID='{0}' doesn't have shopping cart defined.", userID);
                throw new InvalidOperationException(msg);
            }
            var shoppingCartItems = _session.Query<ShoppingCartItem>()
                .Where(s => s.ShoppingCart.ID == shoppingCart.ID).ToList();
            var shoppingCartDataObject = shoppingCart.ToData();
            shoppingCartDataObject.Items = new List<ShoppingCartItemDataObject>();
            if (!shoppingCartItems.Any())
                return shoppingCartDataObject;

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                shoppingCartDataObject.Items.Add(shoppingCartItem.ToData());
            }
            shoppingCartDataObject.Subtotal = shoppingCartDataObject.Items.Sum(p => p.LineAmount);
            return shoppingCartDataObject;
        }

        /// <summary>
        /// 使用指定的商品数量，更新购物篮中的项目。
        /// </summary>
        /// <param name="shoppingCartItemID">需要更新的购物篮项目的全局唯一标识。</param>
        /// <param name="quantity">商品数量。</param>
        public void UpdateShoppingCartItem(Guid shoppingCartItemID, int quantity)
        {
            var shoppingCartItem = _session.Get<ShoppingCartItem>(shoppingCartItemID);
            shoppingCartItem.UpdateQuantity(quantity);
            _session.Update(shoppingCartItem);
        }

        /// <summary>
        /// 将具有指定的全局唯一标识的购物篮项目从购物篮中删除。
        /// </summary>
        /// <param name="shoppingCartItemID">需要删除的购物篮项目的全局唯一标识。</param>
        public void DeleteShoppingCartItem(Guid shoppingCartItemID)
        {
            var shoppingCartItem = _session.Get<ShoppingCartItem>(shoppingCartItemID);
            _session.Delete(shoppingCartItem);
        }

        /// <summary>
        /// 购物结账并产生销售订单。
        /// </summary>
        /// <param name="userID">需要结账并生成订单的客户的全局唯一标识。</param>
        public SalesOrderDataObject Checkout(Guid userID)
        {
            var user = _session.Get<User>(userID);
            var shoppingCart = _session.Query<ShoppingCart>().FirstOrDefault(s => s.User.ID == userID);
            var salesOrder = _domainService.CreateSalesOrder(user, shoppingCart);
            return salesOrder.ToData();
        }

        /// <summary>
        /// 销售订单确认。
        /// </summary>
        /// <param name="orderID">需要被确认的销售订单的全局唯一标识。</param>
        public void Confirm(Guid orderID)
        {
            var salesOrder = _session.Get<SalesOrder>(orderID);
            salesOrder.Confirm();
            _session.Update(salesOrder);
        }

        public void Dispatch(Guid orderID)
        {
            var salesOrder = _session.Get<SalesOrder>(orderID);
            salesOrder.Dispatch();
            _session.Update(salesOrder);
        }

        public IList<SalesOrderDataObject> GetSalesOrdersForUser(Guid userID)
        {
            var salesOrders = _session.Query<SalesOrder>().Where(s => s.User.ID == userID).ToList();
            return salesOrders.Select(salesOrder => salesOrder.ToData()).ToList();
        }

        public IList<SalesOrderDataObject> GetAllSalesOrders()
        {
            var salesOrders = _session.Query<SalesOrder>().OrderByDescending(s => s.DateCreated).ToList();
            return salesOrders.Select(salesOrder => salesOrder.ToData()).ToList();
        }

        /// <summary>
        /// 根据指定的全局唯一标识获取销售订单信息。
        /// </summary>
        /// <param name="orderID">销售订单全局唯一标识。</param>
        /// <returns>包含销售订单信息的数据传输对象。</returns>
        public SalesOrderDataObject GetSalesOrder(Guid orderID)
        {
            var salesOrder = _session.Get<SalesOrder>(orderID);
            return salesOrder.ToData();
        }
    }
}