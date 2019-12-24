using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayTradePrecreateConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradePrecreateConfirmModel : AopObject
    {
        /// <summary>
        /// 买家id
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家id类型：  蚂蚁通行证，取值：  antid
        /// </summary>
        [XmlElement("buyer_id_type")]
        public string BuyerIdType { get; set; }

        /// <summary>
        /// 预下单阶段产生的码串，对应预下单订单。
        /// </summary>
        [XmlElement("confirm_id")]
        public string ConfirmId { get; set; }

        /// <summary>
        /// 预下单阶段的码串类型  订单二维码，取值：qr_code
        /// </summary>
        [XmlElement("confirm_type")]
        public string ConfirmType { get; set; }

        /// <summary>
        /// 业务扩展参数
        /// </summary>
        [XmlElement("extend_params")]
        public TradePrecreateConfirmExtendParam ExtendParams { get; set; }

        /// <summary>
        /// 发卡站ID，由支付宝中国分配
        /// </summary>
        [XmlElement("issuer_id")]
        public string IssuerId { get; set; }
    }
}
