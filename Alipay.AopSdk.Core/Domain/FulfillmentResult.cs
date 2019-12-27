using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// FulfillmentResult Data Structure.
    /// </summary>
    [Serializable]
    public class FulfillmentResult : AopObject
    {
        /// <summary>
        /// 履约单号
        /// </summary>
        [XmlElement("fulfillment_order_no")]
        public string FulfillmentOrderNo { get; set; }

        /// <summary>
        /// 商户履约请求订单号。
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }
    }
}
