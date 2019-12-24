using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayCommerceTransportVehicleownerSettlementQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportVehicleownerSettlementQueryModel : AopObject
    {
        /// <summary>
        /// 业务扣款协议号，由用户申请办理时生成并同步给外部。非支付宝收单必传。
        /// </summary>
        [XmlElement("biz_agreement_no")]
        public string BizAgreementNo { get; set; }

        /// <summary>
        /// 订单支付时传入的商户订单号，商户订单号和交易号两者不能同时为空
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 收单机构交易流水号，商户订单号和交易流水号两者不能同时为空
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
