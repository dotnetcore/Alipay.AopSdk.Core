using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayEbppRechargeFlowSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppRechargeFlowSendModel : AopObject
    {
        /// <summary>
        /// 绑定手机号
        /// </summary>
        [XmlElement("bind_mobile")]
        public string BindMobile { get; set; }

        /// <summary>
        /// 扩展信息，json字符串
        /// </summary>
        [XmlElement("ext_msg")]
        public string ExtMsg { get; set; }

        /// <summary>
        /// 移动兑换流量产品码
        /// </summary>
        [XmlElement("trade_code")]
        public string TradeCode { get; set; }

        /// <summary>
        /// 兑换流量的外部订单号
        /// </summary>
        [XmlElement("trade_id")]
        public string TradeId { get; set; }

        /// <summary>
        /// 兑换交易时间
        /// </summary>
        [XmlElement("trade_time")]
        public string TradeTime { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
