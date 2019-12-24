using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// GoodsSafetyInventoryVO Data Structure.
    /// </summary>
    [Serializable]
    public class GoodsSafetyInventoryVO : AopObject
    {
        /// <summary>
        /// 2018-08-18
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 货品编码
        /// </summary>
        [XmlElement("goods_code")]
        public string GoodsCode { get; set; }

        /// <summary>
        /// 历史平均每天销售
        /// </summary>
        [XmlElement("historical_daily_sales")]
        public string HistoricalDailySales { get; set; }

        /// <summary>
        /// 最小购买数量
        /// </summary>
        [XmlElement("min_order_num")]
        public string MinOrderNum { get; set; }

        /// <summary>
        /// 采购周期
        /// </summary>
        [XmlElement("purchase_cycle")]
        public string PurchaseCycle { get; set; }

        /// <summary>
        /// 安全库存
        /// </summary>
        [XmlElement("safety_inventory")]
        public string SafetyInventory { get; set; }

        /// <summary>
        /// 目标库存
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
