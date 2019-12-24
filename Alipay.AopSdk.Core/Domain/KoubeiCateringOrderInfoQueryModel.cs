using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiCateringOrderInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringOrderInfoQueryModel : AopObject
    {
        /// <summary>
        /// 订单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
