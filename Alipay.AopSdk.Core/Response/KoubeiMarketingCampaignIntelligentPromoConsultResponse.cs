using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignIntelligentPromoConsultResponse.
    /// </summary>
    public class KoubeiMarketingCampaignIntelligentPromoConsultResponse : AopResponse
    {
        /// <summary>
        /// 智能营销方案咨询的模型
        /// </summary>
        [XmlElement("promo")]
        public IntelligentPromo Promo { get; set; }
    }
}
