using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AntMerchantExpandItemOpenCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandItemOpenCreateModel : AopObject
    {
        /// <summary>
        /// 商品描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 商品扩展信息（具体KEY请参见产品文档）
        /// </summary>
        [XmlArray("ext_info")]
        [XmlArrayItem("item_ext_info")]
        public List<ItemExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 素材列表（最多3个）
        /// </summary>
        [XmlArray("material_list")]
        [XmlArrayItem("material_create_info")]
        public List<MaterialCreateInfo> MaterialList { get; set; }

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
        /// 场景码（具体值请参见产品文档）
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 商品SKU列表（至少1个，最多20个）
        /// </summary>
        [XmlArray("sku_list")]
        [XmlArrayItem("sku_create_info")]
        public List<SkuCreateInfo> SkuList { get; set; }

        /// <summary>
        /// 商品所属标准类目ID（具体值请参见产品文档）
        /// </summary>
        [XmlElement("standard_category_id")]
        public string StandardCategoryId { get; set; }

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
        /// 商品类型：STANDARD_GOODS（标品）、NON_STANDARD_GOODS（非标品）
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
