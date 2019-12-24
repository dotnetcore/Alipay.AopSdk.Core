using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AntMerchantExpandFrontcategorySecurityCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandFrontcategorySecurityCreateModel : AopObject
    {
        /// <summary>
        /// 前台类目描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 素材列表（最多3个）
        /// </summary>
        [XmlArray("material_list")]
        [XmlArrayItem("material_create_info")]
        public List<MaterialCreateInfo> MaterialList { get; set; }

        /// <summary>
        /// 前台类目名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 场景码（具体值请参见产品文档）
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 前台类目归属主体ID  例：前台类目归属主体类型为店铺，则前台类目归属主体ID为店铺ID；
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 前台类目归属主体类型:  5（店铺）
        /// </summary>
        [XmlElement("target_type")]
        public string TargetType { get; set; }
    }
}
