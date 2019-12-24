using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieSitesCreateResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieSitesCreateResponse : AopResponse
    {
        /// <summary>
        /// 创建站点的返回值模型
        /// </summary>
        [XmlElement("data")]
        public FengdieActivityCreateModel Data { get; set; }
    }
}
