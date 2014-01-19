using System;

namespace ByteartRetailMini.Domain.Models
{
    [Serializable]
    public class SalesLine : DomainObject
    {
        /// <summary>
        /// 获取当前订单明细的小计金额。
        /// </summary>
        /// <remarks>在严格的业务系统中，金额往往以Money模式实现。有关Money模式，请参见：http://martinfowler.com/eaaCatalog/money.html
        /// </remarks>
        public virtual decimal LineAmount
        {
            get { return Product.UnitPrice * Quantity; }
        }

        /// <summary>
        /// 获取或设置当前订单明细中所包含的商品数量。
        /// </summary>
        public virtual int Quantity { get; set; }

        /// <summary>
        /// 获取或设置属于当前订单明细的商品对象。
        /// </summary>
        public virtual Product Product { get; set; }

        /// <summary>
        /// 获取或设置包含了当前订单明细的销售订单对象。
        /// </summary>
        public virtual SalesOrder SalesOrder { get; set; }
    }
}