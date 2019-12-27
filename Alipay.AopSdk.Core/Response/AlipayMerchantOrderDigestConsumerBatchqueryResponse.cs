using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayMerchantOrderDigestConsumerBatchqueryResponse.
    /// </summary>
    public class AlipayMerchantOrderDigestConsumerBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 是否还有下一页
        /// </summary>
        [XmlElement("has_next_page")]
        public bool HasNextPage { get; set; }

        /// <summary>
        /// 订单信息列表，当存在符合条件的订单时，则返回订单信息；
        /// </summary>
        [XmlArray("order_list")]
        [XmlArrayItem("alipay_order_data_openapi_result_info")]
        public List<AlipayOrderDataOpenapiResultInfo> OrderList { get; set; }
    }
}
