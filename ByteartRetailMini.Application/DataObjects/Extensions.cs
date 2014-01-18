using AutoMapper;
using ByteartRetailMini.Domain.Models;

namespace ByteartRetailMini.Application.DataObjects
{
    public static class Extensions
    {
        static Extensions()
        {
            Mapper.CreateMap<Product, ProductDataObject>();
            Mapper.CreateMap<ProductDataObject, Product>();
            Mapper.CreateMap<Category, CategoryDataObject>();
            Mapper.CreateMap<CategoryDataObject, Category>();
            Mapper.CreateMap<SalesLine, SalesLineDataObject>();
            Mapper.CreateMap<SalesLineDataObject, SalesLine>();
            Mapper.CreateMap<SalesOrder, SalesOrderDataObject>();
            Mapper.CreateMap<SalesOrderDataObject, SalesOrder>();
            Mapper.CreateMap<ShoppingCart, ShoppingCartDataObject>();
            Mapper.CreateMap<ShoppingCartDataObject, ShoppingCart>();
            Mapper.CreateMap<Categorization, CategorizationDataObject>();
            Mapper.CreateMap<CategorizationDataObject, Categorization>();
            Mapper.CreateMap<ShoppingCartItem, ShoppingCartItemDataObject>();
            Mapper.CreateMap<ShoppingCartItemDataObject, ShoppingCartItem>();

            Mapper.CreateMap<User, UserDataObject>();
            Mapper.CreateMap<UserDataObject, User>();
            Mapper.CreateMap<Role, RoleDataObject>();
            Mapper.CreateMap<RoleDataObject, Role>();
            Mapper.CreateMap<Address, AddressDataObject>();
            Mapper.CreateMap<AddressDataObject, Address>();

        }

        public static ProductDataObject ToData(this Product product)
        {
            return Mapper.Map<Product, ProductDataObject>(product);
        }

        public static Product ToDomain(this ProductDataObject productDataObject)
        {
            return Mapper.Map<ProductDataObject, Product>(productDataObject);
        }

        public static CategoryDataObject ToData(this Category category)
        {
            return Mapper.Map<Category, CategoryDataObject>(category);
        }

        public static Category ToDomain(this CategoryDataObject categoryDataObject)
        {
            return Mapper.Map<CategoryDataObject, Category>(categoryDataObject);
        }

        public static SalesLineDataObject ToData(this SalesLine salesLine)
        {
            return Mapper.Map<SalesLine, SalesLineDataObject>(salesLine);
        }

        public static SalesLine ToDomain(this SalesLineDataObject salesLineDataObject)
        {
            return Mapper.Map<SalesLineDataObject, SalesLine>(salesLineDataObject);
        }

        public static SalesOrderDataObject ToData(this SalesOrder salesOrder)
        {
            return Mapper.Map<SalesOrder, SalesOrderDataObject>(salesOrder);
        }

        public static SalesOrder ToDomain(this SalesOrderDataObject salesOrderDataObject)
        {
            return Mapper.Map<SalesOrderDataObject, SalesOrder>(salesOrderDataObject);
        }

        public static ShoppingCartDataObject ToData(this ShoppingCart shoppingCart)
        {
            return Mapper.Map<ShoppingCart, ShoppingCartDataObject>(shoppingCart);
        }

        public static ShoppingCart ToDomain(this ShoppingCartDataObject shoppingCartDataObject)
        {
            return Mapper.Map<ShoppingCartDataObject, ShoppingCart>(shoppingCartDataObject);
        }

        public static ShoppingCartItemDataObject ToData(this ShoppingCartItem shoppingCartItem)
        {
            return Mapper.Map<ShoppingCartItem, ShoppingCartItemDataObject>(shoppingCartItem);
        }

        public static ShoppingCartItem ToDomain(this ShoppingCartItemDataObject shoppingCartItemDataObject)
        {
            return Mapper.Map<ShoppingCartItemDataObject, ShoppingCartItem>(shoppingCartItemDataObject);
        }

        public static CategorizationDataObject ToData(this Categorization categorization)
        {
            return Mapper.Map<Categorization, CategorizationDataObject>(categorization);
        }

        public static Categorization ToDomain(this CategorizationDataObject categorization)
        {
            return Mapper.Map<CategorizationDataObject, Categorization>(categorization);
        }

        public static AddressDataObject ToData(this Address address)
        {
            return Mapper.Map<Address, AddressDataObject>(address);
        }

        public static Address ToDomain(this AddressDataObject addressDataObject)
        {
            return Mapper.Map<AddressDataObject, Address>(addressDataObject);
        }

        public static RoleDataObject ToData(this Role role)
        {
            return Mapper.Map<Role, RoleDataObject>(role);
        }

        public static Role ToDomain(this RoleDataObject roleDataObject)
        {
            return Mapper.Map<RoleDataObject, Role>(roleDataObject);
        }

        public static UserDataObject ToData(this User user)
        {
            return Mapper.Map<User, UserDataObject>(user);
        }

        public static User ToDomain(this UserDataObject userDataObject)
        {
            return Mapper.Map<UserDataObject, User>(userDataObject);
        }
    }
}