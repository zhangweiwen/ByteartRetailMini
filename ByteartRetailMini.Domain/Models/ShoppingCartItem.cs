using System;

namespace ByteartRetailMini.Domain.Models
{
    public partial class ShoppingCartItem : DomainObject
    {
        public virtual int Quantity { get; set; }

        public virtual Product Product { get; set; }

        public virtual ShoppingCart ShoppingCart { get; set; }
    }

    public partial class ShoppingCartItem
    {
        /// <summary>
        /// 将当前的购物篮项目转换为销售订单行。
        /// </summary>
        /// <returns></returns>
        public virtual SalesLine ConvertToSalesLine()
        {
            var salesLine = new SalesLine { ID = Guid.NewGuid(), Product = Product, Quantity = Quantity };
            return salesLine;
        }

        /// <summary>
        /// 更新当前购物篮项目所包含的笔记本电脑商品的个数。
        /// </summary>
        /// <param name="quantity">需要更新的笔记本电脑商品的个数。</param>
        public virtual void UpdateQuantity(int quantity)
        {
            Quantity = quantity;
        }
    }
}