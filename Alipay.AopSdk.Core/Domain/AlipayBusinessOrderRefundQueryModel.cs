using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayBusinessOrderRefundQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBusinessOrderRefundQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 退款请求号，和退款时的退款请求号refund_request_no保持一致。若该参数为空则认为时整单退款查询，返回订单中所有的退款信息
        /// </summary>
        [XmlElement("refund_request_no")]
        public string RefundRequestNo { get; set; }
    }
}
