using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// StuffInfo Data Structure.
    /// </summary>
    [Serializable]
    public class StuffInfo : AopObject
    {
        /// <summary>
        /// 商品描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 扩展字段，保留
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 物料商品SKU号
        /// </summary>
        [XmlElement("sku_no")]
        public string SkuNo { get; set; }

        /// <summary>
        /// 商品规格描述
        /// </summary>
        [XmlElement("standard_description")]
        public string StandardDescription { get; set; }
    }
}
