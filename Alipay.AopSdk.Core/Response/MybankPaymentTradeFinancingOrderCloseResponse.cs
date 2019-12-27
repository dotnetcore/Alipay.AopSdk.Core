using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// MybankPaymentTradeFinancingOrderCloseResponse.
    /// </summary>
    public class MybankPaymentTradeFinancingOrderCloseResponse : AopResponse
    {
        /// <summary>
        /// 外部业务单号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 处理结果状态
        /// </summary>
        [XmlElement("biz_sts")]
        public string BizSts { get; set; }

        /// <summary>
        /// 网商订单编号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 请求受理时间
        /// </summary>
        [XmlElement("request_accept_time")]
        public string RequestAcceptTime { get; set; }
    }
}
