using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiTradeKbdeliveryDeliveryCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiTradeKbdeliveryDeliveryCancelModel : AopObject
    {
        /// <summary>
        /// 口碑物流单，单号；  需要撤销的单据号
        /// </summary>
        [XmlElement("logistics_order_no")]
        public string LogisticsOrderNo { get; set; }

        /// <summary>
        /// 关闭物流订单原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }
    }
}
