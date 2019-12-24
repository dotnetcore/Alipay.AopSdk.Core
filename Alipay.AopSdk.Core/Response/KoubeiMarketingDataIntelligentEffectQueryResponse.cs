using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// KoubeiMarketingDataIntelligentEffectQueryResponse.
    /// </summary>
    public class KoubeiMarketingDataIntelligentEffectQueryResponse : AopResponse
    {
        /// <summary>
        /// 咨询后返回的模型，包含活动本身的模型以及效果模型
        /// </summary>
        [XmlElement("promo")]
        public IntelligentPromo Promo { get; set; }
    }
}
