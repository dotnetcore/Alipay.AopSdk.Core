using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// SkuCreateInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SkuCreateInfo : AopObject
    {
        /// <summary>
        /// 库存
        /// </summary>
        [XmlElement("inventory")]
        public long Inventory { get; set; }

        /// <summary>
        /// SKU素材列表（最多3个）
        /// </summary>
        [XmlArray("material_list")]
        [XmlArrayItem("material_create_info")]
        public List<MaterialCreateInfo> MaterialList { get; set; }

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
        /// SKU属性列表
        /// </summary>
        [XmlArray("property_list")]
        [XmlArrayItem("item_sku_property_info")]
        public List<ItemSkuPropertyInfo> PropertyList { get; set; }
    }
}
