using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// MybankPaymentTradeFinancingOrderRefundResponse.
    /// </summary>
    public class MybankPaymentTradeFinancingOrderRefundResponse : AopResponse
    {
        /// <summary>
        /// 处理结果状态
        /// </summary>
        [XmlElement("biz_sts")]
        public string BizSts { get; set; }

        /// <summary>
        /// 请求受理单号
        /// </summary>
        [XmlElement("operate_no")]
        public string OperateNo { get; set; }

        /// <summary>
        /// 请求受理时间
        /// </summary>
        [XmlElement("request_accept_time")]
        public string RequestAcceptTime { get; set; }

        /// <summary>
        /// 请求流水号
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }
    }
}
