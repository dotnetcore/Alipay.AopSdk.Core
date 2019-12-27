using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayMarketingCampaignCertCreateResponse.
    /// </summary>
    public class AlipayMarketingCampaignCertCreateResponse : AopResponse
    {
        /// <summary>
        /// 凭证id
        /// </summary>
        [XmlElement("lot_number")]
        public string LotNumber { get; set; }
    }
}
