using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayMerchantOrderSecuritydetailConsumerQueryResponse.
    /// </summary>
    public class AlipayMerchantOrderSecuritydetailConsumerQueryResponse : AopResponse
    {
        /// <summary>
        /// 订单信息  若订单号或业务号存在，则返回
        /// </summary>
        [XmlElement("order_info")]
        public AlipayOrderDataOpenapiResultInfo OrderInfo { get; set; }
    }
}
