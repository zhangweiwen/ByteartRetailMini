using System;

namespace ByteartRetailMini.Domain.Models
{
    [Serializable]
    public partial class User : DomainObject
    {
        public User()
        {
            ContactAddress = Address.Emtpy;
            DeliveryAddress = Address.Emtpy;
        }

        /// <summary>
        /// 获取或设置当前客户的电子邮件地址。
        /// </summary>
        public virtual string Email { get; set; }

        /// <summary>
        /// 获取或设置当前客户的联系人信息。
        /// </summary>
        public virtual string Contact { get; set; }

        /// <summary>
        /// 获取或设置当前客户的用户名。
        /// </summary>
        public virtual string UserName { get; set; }

        /// <summary>
        /// 获取或设置当前客户的登录密码。
        /// </summary>
        public virtual string Password { get; set; }

        /// <summary>
        /// 获取或设置一个<see cref="Boolean"/>值，该值表示当前用户账户是否已被禁用。
        /// </summary>
        /// <remarks>在ByteartRetail V3中，仅提供对此属性的管理界面，在实际业务处理中
        /// 并没有使用到该属性。</remarks>
        public virtual bool IsDisabled { get; set; }

        /// <summary>
        /// 获取或设置用户账户的联系电话信息。
        /// </summary>
        public virtual string PhoneNumber { get; set; }

        /// <summary>
        /// 获取或设置用户账户的联系地址。
        /// </summary>
        public virtual Address ContactAddress { get; set; }

        /// <summary>
        /// 获取或设置用户账户注册的时间。
        /// </summary>
        public virtual DateTime DateRegistered { get; set; }

        /// <summary>
        /// 获取或设置用户账户最后一次登录的时间。
        /// </summary>
        /// <remarks>在ByteartRetail V3中，仅提供对此属性的管理界面，在实际业务处理中
        /// 并没有使用到该属性。</remarks>
        public virtual DateTime? DateLastLogon { get; set; }

        /// <summary>
        /// 获取或设置用户账户的发货地址。
        /// </summary>
        public virtual Address DeliveryAddress { get; set; }
    }

    public partial class User
    {
        /// <summary>
        /// 返回表示当前Object的字符串。
        /// </summary>
        /// <returns>表示当前对象的字符串。</returns>
        public override string ToString()
        {
            return UserName;
        }

        /// <summary>
        /// 禁用当前账户。
        /// </summary>
        public virtual void Disable()
        {
            IsDisabled = true;
        }

        /// <summary>
        /// 启用当前账户。
        /// </summary>
        public virtual void Enable()
        {
            IsDisabled = false;
        }

        /// <summary>
        /// 为当前用户创建购物篮。
        /// </summary>
        /// <returns>已创建的购物篮实例，该购物篮为当前用户所用。</returns>
        public virtual ShoppingCart CreateShoppingCart()
        {
            var shoppingCart = new ShoppingCart { User = this };
            return shoppingCart;
        }
    }
}