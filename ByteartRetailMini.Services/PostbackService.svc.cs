using System.ServiceModel;
using System.ServiceModel.Activation;
using ByteartRetailMini.Application;
using ByteartRetailMini.Application.DataObjects;

namespace ByteartRetailMini.Services
{
    [ServiceContract(Namespace = "zhww@outlook.com")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class PostbackService
    {
        public IPostbackService PostbackAppService { get; set; }

        [OperationContract]
        public PostbackDataObject GetPostback()
        {
            return PostbackAppService.GetPostback();
        }
    }
}