using System;
using System.Diagnostics;

namespace ByteartRetailMini.Domain.Models
{
    [Serializable]
    public partial class Product : DomainObject
    {
        /// <summary>
        /// 获取或设置商品的名称。
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// 获取或设置用于表述商品外观的图片的URL地址。
        /// </summary>
        public virtual string ImageUrl { get; set; }

        /// <summary>
        /// 获取或设置一个<see cref="Boolean"/>值，该值表述当前商品
        /// 是否为特色商品。
        /// </summary>
        public virtual bool IsFeatured { get; set; }

        /// <summary>
        /// 获取或设置商品的单价。
        /// </summary>
        /// <remarks>
        /// 在实际的销售系统中，商品单价并不是一个固定的值，它可以是
        /// 一个估价，也可以是一个加权平均值。这就需要涉及到库存管理系统，
        /// 本案例对这部分内容不作演示。
        /// </remarks>
        public virtual decimal UnitPrice { get; set; }

        /// <summary>
        /// 获取或设置商品的描述信息。
        /// </summary>
        public virtual string Description { get; set; }
    }

    public partial class Product
    {
        public override string ToString()
        {
            Debug.Assert(string.IsNullOrWhiteSpace(Name) == false);
            return Name;
        } 
    }
}