using ByteartRetailMini.Application.DataObjects;

namespace ByteartRetailMini.Application
{
    public interface IPostbackService 
    {
        /// <summary>
        /// 将服务器相关的信息回发给客户端。
        /// </summary>
        /// <returns>服务器相关信息。</returns>
        /// <remarks>此服务仅用于测试，没有实际业务含义。</remarks>
        PostbackDataObject GetPostback();
    }
}