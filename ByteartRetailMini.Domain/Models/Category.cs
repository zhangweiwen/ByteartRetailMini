using System.Diagnostics;

namespace ByteartRetailMini.Domain.Models
{
    public partial class Category : DomainObject
    {
        /// <summary>
        /// 获取或设置商品分类的名称。
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// 获取或设置商品分类的描述信息。
        /// </summary>
        public virtual string Description { get; set; }
    }

    public partial class Category
    {
        public override string ToString()
        {
            Debug.Assert(string.IsNullOrWhiteSpace(Name) == false);
            return Name;
        } 
    }
}