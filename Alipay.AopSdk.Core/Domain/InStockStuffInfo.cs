using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// InStockStuffInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InStockStuffInfo : AopObject
    {
        /// <summary>
        /// 实收数量
        /// </summary>
        [XmlElement("actual_qty")]
        public string ActualQty { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 计划数量
        /// </summary>
        [XmlElement("plan_qty")]
        public long PlanQty { get; set; }

        /// <summary>
        /// 物料sku
        /// </summary>
        [XmlElement("sku_no")]
        public string SkuNo { get; set; }
    }
}
