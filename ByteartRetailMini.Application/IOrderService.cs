using System;
using System.Collections.Generic;
using ByteartRetailMini.Application.DataObjects;

namespace ByteartRetailMini.Application
{
    public interface IOrderService
    {
        /// <summary>
        /// 获取指定用户的购物篮中所有项目的个数。
        /// </summary>
        /// <param name="userID">指定用户的ID值。</param>
        /// <returns>指定用户的购物篮中所有项目的个数。</returns>
        int GetShoppingCartItemCount(Guid userID);

        /// <summary>
        /// 将指定的商品添加到指定客户的购物篮里。
        /// </summary>
        /// <param name="userID">用于指代特定客户对象的全局唯一标识。</param>
        /// <param name="productID">用于指代特定商品对象的全局唯一标识。</param>
        /// <param name="quantity">数量</param>
        void AddProductToCart(Guid userID, Guid productID, int quantity);

        /// <summary>
        /// 根据指定客户对象的全局唯一标识，获取该客户的购物篮信息。
        /// </summary>
        /// <param name="userID">用于指代特定客户对象的全局唯一标识。</param>
        /// <returns>包含了购物篮信息的数据传输对象。</returns>
        ShoppingCartDataObject GetShoppingCart(Guid userID);

        /// <summary>
        /// 使用指定的商品数量，更新购物篮中的项目。
        /// </summary>
        /// <param name="shoppingCartItemID">需要更新的购物篮项目的全局唯一标识。</param>
        /// <param name="quantity">商品数量。</param>
        void UpdateShoppingCartItem(Guid shoppingCartItemID, int quantity);

        /// <summary>
        /// 将具有指定的全局唯一标识的购物篮项目从购物篮中删除。
        /// </summary>
        /// <param name="shoppingCartItemID">需要删除的购物篮项目的全局唯一标识。</param>
        void DeleteShoppingCartItem(Guid shoppingCartItemID);

        /// <summary>
        /// 购物结账并产生销售订单。
        /// </summary>
        /// <param name="customerID">需要结账并生成订单的客户的全局唯一标识。</param>
        SalesOrderDataObject Checkout(Guid customerID);

        /// <summary>
        /// 销售订单确认。
        /// </summary>
        /// <param name="orderID">需要被确认的销售订单的全局唯一标识。</param>
        void Confirm(Guid orderID);

        /// <summary>
        /// 处理发货业务。
        /// </summary>
        /// <param name="orderID">需要进行发货的订单ID值。</param>
        void Dispatch(Guid orderID);

        /// <summary>
        /// 根据指定的用户ID值，获取该用户的所有订单。
        /// </summary>
        /// <param name="userID">用户ID值。</param>
        /// <returns>指定用户的所有订单。</returns>
        IList<SalesOrderDataObject> GetSalesOrdersForUser(Guid userID);

        /// <summary>
        /// 获取系统中的所有订单。
        /// </summary>
        /// <returns>所有订单。</returns>
        IList<SalesOrderDataObject> GetAllSalesOrders();

        /// <summary>
        /// 根据指定的全局唯一标识获取销售订单信息。
        /// </summary>
        /// <param name="orderID">销售订单全局唯一标识。</param>
        /// <returns>包含销售订单信息的数据传输对象。</returns>
        SalesOrderDataObject GetSalesOrder(Guid orderID);
    }
}