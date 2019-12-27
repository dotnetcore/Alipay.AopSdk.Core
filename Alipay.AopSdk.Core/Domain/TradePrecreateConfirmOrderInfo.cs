using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// TradePrecreateConfirmOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TradePrecreateConfirmOrderInfo : AopObject
    {
        /// <summary>
        /// 对交易或商品的描述
        /// </summary>
        [XmlElement("body")]
        public string Body { get; set; }

        /// <summary>
        /// 支付超时的绝对时间
        /// </summary>
        [XmlElement("pay_expire_time")]
        public string PayExpireTime { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }
    }
}
