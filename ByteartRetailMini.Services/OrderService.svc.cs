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
        public virtual int GetShoppingCartItemCount(string userName)
        {
            return OrderAppService.GetShoppingCartItemCount(userName);
        }

        [OperationContract]
        public virtual void AddProductToCart(string userName, int productID, int quantity)
        {
            OrderAppService.AddProductToCart(userName, productID, quantity);
        }

        [OperationContract]
        public virtual ShoppingCartDataObject GetShoppingCart(string userName)
        {
            return OrderAppService.GetShoppingCart(userName);
        }

        [OperationContract]
        public virtual void UpdateShoppingCartItem(int shoppingCartItemID, int quantity)
        {
            OrderAppService.UpdateShoppingCartItem(shoppingCartItemID, quantity);
        }

        [OperationContract]
        public virtual void DeleteShoppingCartItem(int shoppingCartItemID)
        {
            OrderAppService.DeleteShoppingCartItem(shoppingCartItemID);
        }

        [OperationContract]
        public virtual SalesOrderDataObject Checkout(string userName)
        {
            return OrderAppService.Checkout(userName);
        }

        [OperationContract]
        public virtual void Confirm(int orderID)
        {
            OrderAppService.Confirm(orderID);
        }

        [OperationContract]
        public virtual void Dispatch(int orderID)
        {
            OrderAppService.Dispatch(orderID);
        }

        [OperationContract]
        public virtual IList<SalesOrderDataObject> GetSalesOrdersForUser(int userID)
        {
            return OrderAppService.GetSalesOrdersForUser(userID);
        }

        [OperationContract]
        public virtual IList<SalesOrderDataObject> GetAllSalesOrders()
        {
            return OrderAppService.GetAllSalesOrders();
        }

        [OperationContract]
        public virtual SalesOrderDataObject GetSalesOrder(int orderID)
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