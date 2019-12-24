using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignActivityQueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignActivityQueryResponse : AopResponse
    {
        /// <summary>
        /// 活动详情
        /// </summary>
        [XmlElement("camp_detail")]
        public CampDetail CampDetail { get; set; }
    }
}
