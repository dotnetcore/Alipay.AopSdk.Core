using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayMarketingExchangevoucherUseResponse.
    /// </summary>
    public class AlipayMarketingExchangevoucherUseResponse : AopResponse
    {
        /// <summary>
        /// 被核销的券ID
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
