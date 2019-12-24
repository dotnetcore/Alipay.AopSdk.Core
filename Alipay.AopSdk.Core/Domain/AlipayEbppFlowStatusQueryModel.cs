using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayEbppFlowStatusQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppFlowStatusQueryModel : AopObject
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("ext_msg")]
        public string ExtMsg { get; set; }

        /// <summary>
        /// 内部订单号
        /// </summary>
        [XmlElement("merchant_order_id")]
        public string MerchantOrderId { get; set; }

        /// <summary>
        /// 手机号码，15158886666
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 外部交易号
        /// </summary>
        [XmlElement("trade_id")]
        public string TradeId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
