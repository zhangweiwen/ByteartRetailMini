using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using Autofac;

namespace ByteartRetailMini.Services.Core
{
    public class IocInstanceProvider : IInstanceProvider
    {
        private readonly Type _serviceType;
        private readonly IContainer _container;

        public IocInstanceProvider(Type serviceType)
        {
            _serviceType = serviceType;
            _container = IocHelper.Container;//TODO: Set IContainer value
        }

        public object GetInstance(InstanceContext instanceContext)
        {
            if (instanceContext == null)
                throw new ArgumentNullException("instanceContext");

            return _container.Resolve(_serviceType);
        }

        public object GetInstance(InstanceContext instanceContext, Message message)
        {
            if (instanceContext == null)
                throw new ArgumentNullException("instanceContext");

            return _container.Resolve(_serviceType);
        }

        public void ReleaseInstance(InstanceContext instanceContext, object instance)
        {
            var disposable = instance as IDisposable;
            if (disposable != null)
                disposable.Dispose();
        }
    }
}