using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// GoodsSafetyInventory Data Structure.
    /// </summary>
    [Serializable]
    public class GoodsSafetyInventory : AopObject
    {
        /// <summary>
        /// 货品编码
        /// </summary>
        [XmlElement("goods_code")]
        public string GoodsCode { get; set; }

        /// <summary>
        /// 最小采购量
        /// </summary>
        [XmlElement("min_order_num")]
        public string MinOrderNum { get; set; }

        /// <summary>
        /// 采购周期（单位天）
        /// </summary>
        [XmlElement("purchase_cycle")]
        public string PurchaseCycle { get; set; }

        /// <summary>
        /// 安全库存数量
        /// </summary>
        [XmlElement("safety_inventory")]
        public string SafetyInventory { get; set; }

        /// <summary>
        /// 目标库存数量
        /// </summary>
        [XmlElement("target_inventory")]
        public string TargetInventory { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        [XmlElement("warehouse_code")]
        public string WarehouseCode { get; set; }
    }
}
