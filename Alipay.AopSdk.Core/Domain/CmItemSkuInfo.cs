using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// CmItemSkuInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CmItemSkuInfo : AopObject
    {
        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 库存
        /// </summary>
        [XmlElement("inventory")]
        public long Inventory { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 素材列表
        /// </summary>
        [XmlArray("material_list")]
        [XmlArrayItem("material_info")]
        public List<MaterialInfo> MaterialList { get; set; }

        /// <summary>
        /// 标价，单位分
        /// </summary>
        [XmlElement("original_price")]
        public long OriginalPrice { get; set; }

        /// <summary>
        /// 售价，单位分
        /// </summary>
        [XmlElement("price")]
        public long Price { get; set; }

        /// <summary>
        /// 剩余库存
        /// </summary>
        [XmlElement("remain_inventory")]
        public long RemainInventory { get; set; }

        /// <summary>
        /// 商品SKU ID
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// SKU属性列表
        /// </summary>
        [XmlArray("sku_property_list")]
        [XmlArrayItem("item_sku_property_info")]
        public List<ItemSkuPropertyInfo> SkuPropertyList { get; set; }

        /// <summary>
        /// 商品SKU状态：  EFFECT(有效)、  INVALID（无效）
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
