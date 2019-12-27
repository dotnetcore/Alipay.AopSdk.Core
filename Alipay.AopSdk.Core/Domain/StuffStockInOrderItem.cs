using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// StuffStockInOrderItem Data Structure.
    /// </summary>
    [Serializable]
    public class StuffStockInOrderItem : AopObject
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 入库单物料数量
        /// </summary>
        [XmlElement("qty")]
        public long Qty { get; set; }

        /// <summary>
        /// sku号
        /// </summary>
        [XmlElement("sku_no")]
        public string SkuNo { get; set; }
    }
}
