using Autofac;
using ByteartRetailMini.Application;

namespace ByteartRetailMini.Services.Core
{
    public abstract class BaseService
    {
        private IUserService _userAppService;
        private IOrderService _orderAppService;
        private IProductService _productAppService;
        private IPostbackService _postbackAppService;

        protected IUserService UserAppService
        {
            get { return _userAppService ?? (_userAppService = IocHelper.Container.Resolve<IUserService>()); }
        }

        protected IOrderService OrderAppService
        {
            get { return _orderAppService ?? (_orderAppService = IocHelper.Container.Resolve<IOrderService>()); }
        }

        protected IProductService ProductAppService
        {
            get { return _productAppService ?? (_productAppService = IocHelper.Container.Resolve<IProductService>()); }
        }

        protected IPostbackService PostbackAppService
        {
            get { return _postbackAppService ?? (_postbackAppService = IocHelper.Container.Resolve<IPostbackService>()); }
        }
    }
}