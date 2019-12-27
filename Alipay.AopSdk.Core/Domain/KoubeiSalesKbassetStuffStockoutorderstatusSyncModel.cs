using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiSalesKbassetStuffStockoutorderstatusSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiSalesKbassetStuffStockoutorderstatusSyncModel : AopObject
    {
        /// <summary>
        /// erp订单号
        /// </summary>
        [XmlElement("erp_order")]
        public string ErpOrder { get; set; }

        /// <summary>
        /// ERP 订单类型
        /// </summary>
        [XmlElement("erp_order_type")]
        public string ErpOrderType { get; set; }

        /// <summary>
        /// 扩展
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlArray("steps")]
        [XmlArrayItem("stock_shipping_step_info")]
        public List<StockShippingStepInfo> Steps { get; set; }

        /// <summary>
        /// 仓库编号
        /// </summary>
        [XmlElement("warehouse_code")]
        public string WarehouseCode { get; set; }

        /// <summary>
        /// 运单号
        /// </summary>
        [XmlElement("way_bill_no")]
        public string WayBillNo { get; set; }
    }
}
