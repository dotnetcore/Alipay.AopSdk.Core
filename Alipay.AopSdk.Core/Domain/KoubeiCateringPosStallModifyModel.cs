using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiCateringPosStallModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosStallModifyModel : AopObject
    {
        /// <summary>
        /// 菜品id列表
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
        /// 打印机id
        /// </summary>
        [XmlElement("printer_id")]
        public string PrinterId { get; set; }

        /// <summary>
        /// 打印机类型（FRONT_DESK_PRINTER：前台打印机；LABEL_PRINTER：标签打印机；KITCHEN_PRINTER：厨房打印机）
        /// </summary>
        [XmlElement("printer_type")]
        public string PrinterType { get; set; }

        /// <summary>
        /// 是否分单打印（"parted"："菜品分开打印"；"together"："菜品统一打印"）
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
