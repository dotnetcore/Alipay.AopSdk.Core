using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// FrontCategoryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FrontCategoryInfo : AopObject
    {
        /// <summary>
        /// 前台类目描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 前台类目ID
        /// </summary>
        [XmlElement("front_category_id")]
        public string FrontCategoryId { get; set; }

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
        /// 素材列表
        /// </summary>
        [XmlArray("material_list")]
        [XmlArrayItem("material_info")]
        public List<MaterialInfo> MaterialList { get; set; }

        /// <summary>
        /// 前台类目名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商品归属主体ID  例：商品归属主体类型为店铺，则商品归属主体ID为店铺ID；
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 商品归属主体类型:  5（店铺）
        /// </summary>
        [XmlElement("target_type")]
        public string TargetType { get; set; }
    }
}
