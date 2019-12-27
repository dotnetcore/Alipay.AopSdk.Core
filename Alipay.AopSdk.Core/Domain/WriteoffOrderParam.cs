using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// WriteoffOrderParam Data Structure.
    /// </summary>
    [Serializable]
    public class WriteoffOrderParam : AopObject
    {
        /// <summary>
        /// 当前子订单是否已结清
        /// </summary>
        [XmlElement("is_clearance")]
        public bool IsClearance { get; set; }

        /// <summary>
        /// 主订单号
        /// </summary>
        [XmlElement("order_num")]
        public string OrderNum { get; set; }

        /// <summary>
        /// 子订单号
        /// </summary>
        [XmlElement("sub_order_num")]
        public string SubOrderNum { get; set; }
    }
}
