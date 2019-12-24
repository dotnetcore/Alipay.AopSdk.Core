using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignItemMerchantactivityCreateResponse.
    /// </summary>
    public class KoubeiMarketingCampaignItemMerchantactivityCreateResponse : AopResponse
    {
        /// <summary>
        /// 运营活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }
    }
}
