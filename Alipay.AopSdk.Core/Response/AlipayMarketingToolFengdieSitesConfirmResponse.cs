using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieSitesConfirmResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieSitesConfirmResponse : AopResponse
    {
        /// <summary>
        /// 返回执行云凤蝶站点审核操作的成功失败状态
        /// </summary>
        [XmlElement("data")]
        public FengdieSuccessRespModel Data { get; set; }
    }
}
