using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignBenefitQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignBenefitQueryModel : AopObject
    {
        /// <summary>
        /// 权益id
        /// </summary>
        [XmlElement("benefit_id")]
        public string BenefitId { get; set; }
    }
}
