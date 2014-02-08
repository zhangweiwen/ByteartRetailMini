using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace ByteartRetailMini.Services.Core
{
    public class IocServiceBehavior : Attribute, IServiceBehavior
    {
        public void Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
        }

        public void AddBindingParameters(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection bindingParameters)
        {
        }

        public void ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
            if (serviceDescription == null)
                throw new ArgumentNullException("serviceDescription");

            if (serviceHostBase == null)
                throw new ArgumentNullException("serviceHostBase");

            var instanceProvider = new IocInstanceProvider(serviceDescription.ServiceType);
            var endpoints = serviceHostBase.ChannelDispatchers.OfType<ChannelDispatcher>().SelectMany(c => c.Endpoints);
            foreach (var endpoint in endpoints)
            {
                endpoint.DispatchRuntime.InstanceProvider = instanceProvider;
            }
        }
    }
}