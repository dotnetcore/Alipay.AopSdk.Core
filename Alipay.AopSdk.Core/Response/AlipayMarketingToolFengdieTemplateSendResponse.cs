using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieTemplateSendResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieTemplateSendResponse : AopResponse
    {
        /// <summary>
        /// 分配模板的操作是否成功
        /// </summary>
        [XmlElement("data")]
        public FengdieSuccessRespModel Data { get; set; }
    }
}
