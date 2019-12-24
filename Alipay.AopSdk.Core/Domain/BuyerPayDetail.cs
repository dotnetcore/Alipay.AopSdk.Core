using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// BuyerPayDetail Data Structure.
    /// </summary>
    [Serializable]
    public class BuyerPayDetail : AopObject
    {
        /// <summary>
        /// 买家支付金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 支付渠道
        /// </summary>
        [XmlElement("pay_channel")]
        public string PayChannel { get; set; }
    }
}
