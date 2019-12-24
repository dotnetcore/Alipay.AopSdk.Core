using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// CmItemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CmItemInfo : AopObject
    {
        /// <summary>
        /// 商品描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 商品扩展信息
        /// </summary>
        [XmlArray("ext_info")]
        [XmlArrayItem("item_ext_info")]
        public List<ItemExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 商品所属前台类目ID列表
        /// </summary>
        [XmlArray("front_category_id_list")]
        [XmlArrayItem("string")]
        public List<string> FrontCategoryIdList { get; set; }

        /// <summary>
        /// 商品创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 商品更新时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品素材列表
        /// </summary>
        [XmlArray("material_list")]
        [XmlArrayItem("material_info")]
        public List<MaterialInfo> MaterialList { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商品属性列表
        /// </summary>
        [XmlArray("property_list")]
        [XmlArrayItem("item_property_info")]
        public List<ItemPropertyInfo> PropertyList { get; set; }

        /// <summary>
        /// 商品SKU列表
        /// </summary>
        [XmlArray("sku_list")]
        [XmlArrayItem("cm_item_sku_info")]
        public List<CmItemSkuInfo> SkuList { get; set; }

        /// <summary>
        /// 商品所属标准类目ID（具体值请参见产品文档）
        /// </summary>
        [XmlElement("standard_category_id")]
        public string StandardCategoryId { get; set; }

        /// <summary>
        /// 商品状态：  EFFECT（有效）、INVALID（无效）
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 商品归属主体ID  例：商品归属主体类型为店铺，则商品归属主体ID为店铺ID；归属主体为小程序，则归属主体ID为小程序ID
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 商品归属主体类型:  5（店铺）  8（小程序）
        /// </summary>
        [XmlElement("target_type")]
        public string TargetType { get; set; }

        /// <summary>
        /// 商品类型：  STANDARD_GOODS（标品）、NON_STANDARD_GOODS（非标品）
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
