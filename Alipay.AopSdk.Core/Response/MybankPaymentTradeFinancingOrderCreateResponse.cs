using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// MybankPaymentTradeFinancingOrderCreateResponse.
    /// </summary>
    public class MybankPaymentTradeFinancingOrderCreateResponse : AopResponse
    {
        /// <summary>
        /// 处理结果状态
        /// </summary>
        [XmlElement("biz_sts")]
        public string BizSts { get; set; }

        /// <summary>
        /// 请求受理单号，网商创建订单成功后返回的订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

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
