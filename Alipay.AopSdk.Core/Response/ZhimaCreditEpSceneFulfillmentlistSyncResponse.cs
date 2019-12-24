using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// ZhimaCreditEpSceneFulfillmentlistSyncResponse.
    /// </summary>
    public class ZhimaCreditEpSceneFulfillmentlistSyncResponse : AopResponse
    {
        /// <summary>
        /// 履约同步结果列表
        /// </summary>
        [XmlArray("fulfillment_result_list")]
        [XmlArrayItem("fulfillment_result")]
        public List<FulfillmentResult> FulfillmentResultList { get; set; }
    }
}
