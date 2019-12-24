using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayMarketingCampaignActivityOfflineCreateResponse.
    /// </summary>
    public class AlipayMarketingCampaignActivityOfflineCreateResponse : AopResponse
    {
        /// <summary>
        /// 创建成功的活动id
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 创建成功的券模版id
        /// </summary>
        [XmlElement("prize_id")]
        public string PrizeId { get; set; }
    }
}
