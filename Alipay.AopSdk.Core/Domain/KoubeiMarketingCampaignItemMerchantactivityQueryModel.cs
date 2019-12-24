using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignItemMerchantactivityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignItemMerchantactivityQueryModel : AopObject
    {
        /// <summary>
        /// 运营活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 外部id
        /// </summary>
        [XmlElement("external_unique_id")]
        public string ExternalUniqueId { get; set; }
    }
}
