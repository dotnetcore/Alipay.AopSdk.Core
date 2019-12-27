using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiMallScanpurchasePreorderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMallScanpurchasePreorderQueryModel : AopObject
    {
        /// <summary>
        /// 预订单编号
        /// </summary>
        [XmlElement("advance_order_id")]
        public string AdvanceOrderId { get; set; }
    }
}
