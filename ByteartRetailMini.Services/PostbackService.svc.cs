using System.ServiceModel;
using System.ServiceModel.Activation;
using Autofac;
using ByteartRetailMini.Application;
using ByteartRetailMini.Application.DataObjects;
using ByteartRetailMini.Services.Core;

namespace ByteartRetailMini.Services
{
    [IocServiceBehavior]
    [ServiceContract(Namespace = "zhww@outlook.com")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class PostbackService : BaseService
    {
        [OperationContract]
        public virtual PostbackDataObject GetPostback()
        {
            return PostbackAppService.GetPostback();
        }
    }
}