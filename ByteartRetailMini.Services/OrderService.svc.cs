using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Activation;
using Autofac;
using ByteartRetailMini.Application;
using ByteartRetailMini.Application.DataObjects;

namespace ByteartRetailMini.Services
{
    [ServiceContract(Namespace = "zhww@outlook.com")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class OrderService
    {
        public IOrderService OrderAppService { get; set; }

        [OperationContract]
        public int GetShoppingCartItemCount(Guid userID)
        {
            return OrderAppService.GetShoppingCartItemCount(userID);
        }

        [OperationContract]
        public void AddProductToCart(Guid userID, Guid productID, int quantity)
        {
            OrderAppService.AddProductToCart(userID, productID, quantity);
        }

        [OperationContract]
        public ShoppingCartDataObject GetShoppingCart(Guid userID)
        {
            return OrderAppService.GetShoppingCart(userID);
        }

        [OperationContract]
        public void UpdateShoppingCartItem(Guid shoppingCartItemID, int quantity)
        {
            OrderAppService.UpdateShoppingCartItem(shoppingCartItemID, quantity);
        }

        [OperationContract]
        public void DeleteShoppingCartItem(Guid shoppingCartItemID)
        {
            OrderAppService.DeleteShoppingCartItem(shoppingCartItemID);
        }

        [OperationContract]
        public SalesOrderDataObject Checkout(Guid customerID)
        {
            return OrderAppService.Checkout(customerID);
        }

        [OperationContract]
        public void Confirm(Guid orderID)
        {
            OrderAppService.Confirm(orderID);
        }

        [OperationContract]
        public void Dispatch(Guid orderID)
        {
            OrderAppService.Dispatch(orderID);
        }

        [OperationContract]
        public IList<SalesOrderDataObject> GetSalesOrdersForUser(Guid userID)
        {
            return OrderAppService.GetSalesOrdersForUser(userID);
        }

        [OperationContract]
        public IList<SalesOrderDataObject> GetAllSalesOrders()
        {
            return OrderAppService.GetAllSalesOrders();
        }

        [OperationContract]
        public SalesOrderDataObject GetSalesOrder(Guid orderID)
        {
            return OrderAppService.GetSalesOrder(orderID);
        }
    }
}