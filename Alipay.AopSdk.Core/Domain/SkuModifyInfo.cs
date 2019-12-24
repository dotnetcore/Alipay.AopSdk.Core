using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// SkuModifyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SkuModifyInfo : AopObject
    {
        /// <summary>
        /// 库存
        /// </summary>
        [XmlElement("inventory")]
        public long Inventory { get; set; }

        /// <summary>
        /// SKU素材列表（会和SKU已存在素材做差异化比较后做增删改操作）
        /// </summary>
        [XmlArray("material_list")]
        [XmlArrayItem("material_modify_info")]
        public List<MaterialModifyInfo> MaterialList { get; set; }

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
        /// SKU属性列表（覆盖SKU已存在属性）
        /// </summary>
        [XmlArray("property_list")]
        [XmlArrayItem("item_sku_property_info")]
        public List<ItemSkuPropertyInfo> PropertyList { get; set; }

        /// <summary>
        /// SKU ID（传空表示新增对应SKU）
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }
    }
}
