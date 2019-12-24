using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// StuffStockInOrder Data Structure.
    /// </summary>
    [Serializable]
    public class StuffStockInOrder : AopObject
    {
        /// <summary>
        /// 口碑物料平台商品入库ERP号
        /// </summary>
        [XmlElement("erp_order")]
        public string ErpOrder { get; set; }

        /// <summary>
        /// ERP订单类型
        /// </summary>
        [XmlElement("erp_order_type")]
        public string ErpOrderType { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 入库单明细
        /// </summary>
        [XmlArray("order_items")]
        [XmlArrayItem("stuff_stock_in_order_item")]
        public List<StuffStockInOrderItem> OrderItems { get; set; }

        /// <summary>
        /// 预计收货时间(YYYY-MM-DD HH:mm:ss)
        /// </summary>
        [XmlElement("scheduled_receipt_date")]
        public string ScheduledReceiptDate { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        [XmlElement("warehouse_code")]
        public string WarehouseCode { get; set; }
    }
}
