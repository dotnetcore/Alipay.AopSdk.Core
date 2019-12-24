using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiTradeOrderEnterpriseQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiTradeOrderEnterpriseQueryModel : AopObject
    {
        /// <summary>
        /// 口碑订单号，和外部订单号不能同时为空
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 创建订单时传入的商户订单号,和口碑订单号不能同时为空
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 商户签约支付宝的账号,和口碑订单号不能同时为空
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }
    }
}
