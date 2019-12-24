using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// ZhimaCreditEpSceneFulfillmentSyncResponse.
    /// </summary>
    public class ZhimaCreditEpSceneFulfillmentSyncResponse : AopResponse
    {
        /// <summary>
        /// 履约单号
        /// </summary>
        [XmlElement("fulfillment_order_no")]
        public string FulfillmentOrderNo { get; set; }
    }
}
