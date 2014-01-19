using System;

namespace ByteartRetailMini.Domain.Models
{
    /// <summary>
    /// 表示商品的分类信息的对象。
    /// </summary>
    [Serializable]
    public partial class Categorization : DomainObject
    {
        public virtual Guid CategoryID { get; set; }

        public virtual Guid ProductID { get; set; }

        public override string ToString()
        {
            return string.Format("CategoryID: {0}, ProductID: {1}", CategoryID, ProductID);
        }
    }

    public partial class Categorization
    {
        /// <summary>
        /// 创建商品与分类之间的关系。
        /// </summary>
        /// <param name="product">商品实体。</param>
        /// <param name="category">分类实体。</param>
        /// <returns>描述商品与分类之间关系的实体。</returns>
        public static Categorization CreateCategorization(Product product, Category category)
        {
            return new Categorization { ProductID = product.ID, CategoryID = category.ID };
        }
    }
}