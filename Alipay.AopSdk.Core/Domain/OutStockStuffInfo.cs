using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// OutStockStuffInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OutStockStuffInfo : AopObject
    {
        /// <summary>
        /// 实出库数量
        /// </summary>
        [XmlElement("actual_qty")]
        public long ActualQty { get; set; }

        /// <summary>
        /// 扩展
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 物料sku
        /// </summary>
        [XmlElement("sku_no")]
        public string SkuNo { get; set; }
    }
}
