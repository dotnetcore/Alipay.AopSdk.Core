using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiSalesKbassetStuffLogisticsoutstockSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiSalesKbassetStuffLogisticsoutstockSyncModel : AopObject
    {
        /// <summary>
        /// 实际发货时间
        /// </summary>
        [XmlElement("actual_ship_date_time")]
        public string ActualShipDateTime { get; set; }

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
        /// 顺丰为SF
        /// </summary>
        [XmlElement("express_company_code")]
        public string ExpressCompanyCode { get; set; }

        /// <summary>
        /// 物流公司名称
        /// </summary>
        [XmlElement("express_company_name")]
        public string ExpressCompanyName { get; set; }

        /// <summary>
        /// 扩展
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 出库明细
        /// </summary>
        [XmlArray("item_infos")]
        [XmlArrayItem("out_stock_stuff_info")]
        public List<OutStockStuffInfo> ItemInfos { get; set; }

        /// <summary>
        /// 由调用方提供的一个唯一的请求ID，每一个请求对应一个id，用于实现调用幂等
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 回单号
        /// </summary>
        [XmlElement("return_tracking")]
        public string ReturnTracking { get; set; }

        /// <summary>
        /// 顺丰的出库号
        /// </summary>
        [XmlElement("shipment_id")]
        public string ShipmentId { get; set; }

        /// <summary>
        /// 运单号
        /// </summary>
        [XmlElement("way_bill_no")]
        public string WayBillNo { get; set; }
    }
}
