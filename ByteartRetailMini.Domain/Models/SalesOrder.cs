using System;
using System.Collections.Generic;
using System.Linq;

namespace ByteartRetailMini.Domain.Models
{
    public partial class SalesOrder : DomainObject
    {
        private List<SalesLine> _salesLines = new List<SalesLine>();

        /// <summary>
        /// 获取该销售订单的金额。
        /// </summary>
        /// <remarks>在严格的业务系统中，金额往往以Money模式实现。有关Money模式，请参见：http://martinfowler.com/eaaCatalog/money.html
        /// </remarks>
        public virtual decimal Subtotal
        {
            get
            {
                return _salesLines.Sum(p => p.LineAmount);
            }
        }

        /// <summary>
        /// 获取该销售订单的派送地址。
        /// </summary>
        public virtual Address DeliveryAddress
        {
            get { return User.DeliveryAddress; }
        }

        /// <summary>
        /// 获取或设置拥有该销售订单的客户实体。
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        /// 获取或设置销售订单的创建日期。
        /// </summary>
        public virtual DateTime DateCreated { get; set; }

        /// <summary>
        /// 获取或设置销售订单的状态。
        /// </summary>
        public virtual SalesOrderStatus Status { get; set; }

        /// <summary>
        /// 获取或设置销售订单的派送日期。
        /// </summary>
        public virtual DateTime? DateDelivered { get; set; }

        /// <summary>
        /// 获取或设置销售订单的发货日期。
        /// </summary>
        public virtual DateTime? DateDispatched { get; set; }

        /// <summary>
        /// 获取或设置销售订单的订单明细。
        /// </summary>
        public virtual List<SalesLine> SalesLines
        {
            get { return _salesLines; }
            set { _salesLines = value; }
        }
    }


    public partial class SalesOrder
    {
        /// <summary>
        /// 当客户完成收货后，对销售订单进行确认。
        /// </summary>
        public virtual void Confirm()
        {
            Status = SalesOrderStatus.Delivered;
            DateDelivered = DateTime.Now;
        }

        /// <summary>
        /// 处理发货。
        /// </summary>
        public virtual void Dispatch()
        {
            Status = SalesOrderStatus.Dispatched;
            DateDispatched = DateTime.Now;
        }
    }
}