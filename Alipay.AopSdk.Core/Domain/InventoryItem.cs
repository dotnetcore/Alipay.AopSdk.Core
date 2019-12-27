using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// InventoryItem Data Structure.
    /// </summary>
    [Serializable]
    public class InventoryItem : AopObject
    {
        /// <summary>
        /// 可用库存
        /// </summary>
        [XmlElement("available_qty")]
        public long AvailableQty { get; set; }

        /// <summary>
        /// 扩展库存
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 在库库存
        /// </summary>
        [XmlElement("on_hand_qty")]
        public long OnHandQty { get; set; }

        /// <summary>
        /// sku号
        /// </summary>
        [XmlElement("sku_no")]
        public string SkuNo { get; set; }

        /// <summary>
        /// 总库存
        /// </summary>
        [XmlElement("total_qty")]
        public long TotalQty { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        [XmlElement("warehouse_code")]
        public string WarehouseCode { get; set; }
    }
}
