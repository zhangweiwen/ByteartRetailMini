using System;
using System.Collections.Generic;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Activation;
using Autofac;
using ByteartRetailMini.Application;
using ByteartRetailMini.Application.DataObjects;
using ByteartRetailMini.Services.Core;

namespace ByteartRetailMini.Services
{
    [IocServiceBehavior]
    [ServiceContract(Namespace = "zhww@outlook.com")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class OrderService : BaseService
    {
        [OperationContract]
        public virtual int GetShoppingCartItemCount(Guid userID)
        {
            return OrderAppService.GetShoppingCartItemCount(userID);
        }

        [OperationContract]
        public virtual void AddProductToCart(Guid userID, Guid productID, int quantity)
        {
            OrderAppService.AddProductToCart(userID, productID, quantity);
        }

        [OperationContract]
        public virtual ShoppingCartDataObject GetShoppingCart(Guid userID)
        {
            return OrderAppService.GetShoppingCart(userID);
        }

        [OperationContract]
        public virtual void UpdateShoppingCartItem(Guid shoppingCartItemID, int quantity)
        {
            OrderAppService.UpdateShoppingCartItem(shoppingCartItemID, quantity);
        }

        [OperationContract]
        public virtual void DeleteShoppingCartItem(Guid shoppingCartItemID)
        {
            OrderAppService.DeleteShoppingCartItem(shoppingCartItemID);
        }

        [OperationContract]
        public virtual SalesOrderDataObject Checkout(Guid customerID)
        {
            return OrderAppService.Checkout(customerID);
        }

        [OperationContract]
        public virtual void Confirm(Guid orderID)
        {
            OrderAppService.Confirm(orderID);
        }

        [OperationContract]
        public virtual void Dispatch(Guid orderID)
        {
            OrderAppService.Dispatch(orderID);
        }

        [OperationContract]
        public virtual IList<SalesOrderDataObject> GetSalesOrdersForUser(Guid userID)
        {
            return OrderAppService.GetSalesOrdersForUser(userID);
        }

        [OperationContract]
        public virtual IList<SalesOrderDataObject> GetAllSalesOrders()
        {
            return OrderAppService.GetAllSalesOrders();
        }

        [OperationContract]
        public virtual SalesOrderDataObject GetSalesOrder(Guid orderID)
        {
            return OrderAppService.GetSalesOrder(orderID);
        }

        //TODO:remove this operation
        [OperationContract]
        public virtual void Test()
        {
            Console.SetOut(new StreamWriter("1.txt"));
            Console.WriteLine("abc");
            Console.Out.Flush();
        }
    }
}