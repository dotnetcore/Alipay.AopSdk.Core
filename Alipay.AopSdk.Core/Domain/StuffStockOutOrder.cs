using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// StuffStockOutOrder Data Structure.
    /// </summary>
    [Serializable]
    public class StuffStockOutOrder : AopObject
    {
        /// <summary>
        /// 市编号
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 市名称
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 区编号
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 区名称
        /// </summary>
        [XmlElement("district_name")]
        public string DistrictName { get; set; }

        /// <summary>
        /// erp订单号
        /// </summary>
        [XmlElement("erp_order")]
        public string ErpOrder { get; set; }

        /// <summary>
        /// erp订单类型
        /// </summary>
        [XmlElement("erp_order_type")]
        public string ErpOrderType { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 出库单明细
        /// </summary>
        [XmlArray("order_items")]
        [XmlArrayItem("stuff_stock_out_order_item")]
        public List<StuffStockOutOrderItem> OrderItems { get; set; }

        /// <summary>
        /// 省编号
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 省名称
        /// </summary>
        [XmlElement("province_name")]
        public string ProvinceName { get; set; }

        /// <summary>
        /// 收货方地址
        /// </summary>
        [XmlElement("receiver_address")]
        public string ReceiverAddress { get; set; }

        /// <summary>
        /// 收件方公司
        /// </summary>
        [XmlElement("receiver_company")]
        public string ReceiverCompany { get; set; }

        /// <summary>
        /// 收件人
        /// </summary>
        [XmlElement("receiver_name")]
        public string ReceiverName { get; set; }

        /// <summary>
        /// 收件方联系方式
        /// </summary>
        [XmlElement("receiver_phone")]
        public string ReceiverPhone { get; set; }

        /// <summary>
        /// 收件方邮编
        /// </summary>
        [XmlElement("receiver_zip_code")]
        public string ReceiverZipCode { get; set; }

        /// <summary>
        /// 顺丰订单类型
        /// </summary>
        [XmlElement("sf_order_type")]
        public string SfOrderType { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        [XmlElement("warehouse_code")]
        public string WarehouseCode { get; set; }
    }
}
