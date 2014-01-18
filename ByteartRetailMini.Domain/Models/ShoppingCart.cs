namespace ByteartRetailMini.Domain.Models
{
    public class ShoppingCart : DomainObject
    {
        /// <summary>
        /// 获取或设置拥有此购物篮的客户实体。
        /// </summary>
        public virtual User User { get; set; }
    }
}