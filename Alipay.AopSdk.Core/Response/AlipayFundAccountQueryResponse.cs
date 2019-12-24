using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayFundAccountQueryResponse.
    /// </summary>
    public class AlipayFundAccountQueryResponse : AopResponse
    {
        /// <summary>
        /// 可用余额。可用于支付或提现的余额。
        /// </summary>
        [XmlElement("available_amount")]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// 场景余额模式外标卡信息
        /// </summary>
        [XmlElement("ext_card_info")]
        public ExtCardInfo ExtCardInfo { get; set; }
    }
}
