using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiTradeOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiTradeOrderQueryModel : AopObject
    {
        /// <summary>
        /// 口碑订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
