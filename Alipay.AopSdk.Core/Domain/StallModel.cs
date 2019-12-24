using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// StallModel Data Structure.
    /// </summary>
    [Serializable]
    public class StallModel : AopObject
    {
        /// <summary>
        /// 档口下菜品集合
        /// </summary>
        [XmlArray("dish_ids")]
        [XmlArrayItem("string")]
        public List<string> DishIds { get; set; }

        /// <summary>
        /// 档口id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// kds详情信息
        /// </summary>
        [XmlArray("kds_list")]
        [XmlArrayItem("stall_kds_entity")]
        public List<StallKdsEntity> KdsList { get; set; }

        /// <summary>
        /// 打印机id
        /// </summary>
        [XmlElement("printer_id")]
        public string PrinterId { get; set; }

        /// <summary>
        /// 打印机名称
        /// </summary>
        [XmlElement("printer_name")]
        public string PrinterName { get; set; }

        /// <summary>
        /// 是否分单打印（parted：菜品分开打印；together：菜品统一打印）
        /// </summary>
        [XmlElement("receipt_type")]
        public string ReceiptType { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 档口名称
        /// </summary>
        [XmlElement("stall_name")]
        public string StallName { get; set; }

        /// <summary>
        /// 启用情况（false:停用；true:启用）
        /// </summary>
        [XmlElement("use")]
        public bool Use { get; set; }
    }
}
