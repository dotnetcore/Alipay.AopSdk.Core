using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayBusinessOrderRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBusinessOrderRefundModel : AopObject
    {
        /// <summary>
        /// 订单退款环境信息
        /// </summary>
        [XmlElement("env_info")]
        public EnvInfo EnvInfo { get; set; }

        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 退款支付工具列表
        /// </summary>
        [XmlArray("refund_paytool_list")]
        [XmlArrayItem("paytool_refund_request_detail")]
        public List<PaytoolRefundRequestDetail> RefundPaytoolList { get; set; }

        /// <summary>
        /// 退款原因
        /// </summary>
        [XmlElement("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 退款请求号。若退款请求号不为空，则必需传入refund_paytools_list。  若不传入退款请求号，同时refund_paytools_list为空，则认为是全额退款。
        /// </summary>
        [XmlElement("refund_request_no")]
        public string RefundRequestNo { get; set; }
    }
}
