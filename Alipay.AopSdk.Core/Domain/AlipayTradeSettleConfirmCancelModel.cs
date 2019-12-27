using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayTradeSettleConfirmCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeSettleConfirmCancelModel : AopObject
    {
        /// <summary>
        /// 原始确认结算时的请求号，对应于需要撤销的那笔请求
        /// </summary>
        [XmlElement("ori_request_no")]
        public string OriRequestNo { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
