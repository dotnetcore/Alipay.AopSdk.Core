using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AntMerchantExpandFrontcategorySecurityModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandFrontcategorySecurityModifyModel : AopObject
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
        /// 素材列表（会和前台类目已存在素材做差异化比较后做增删改操作）
        /// </summary>
        [XmlArray("material_list")]
        [XmlArrayItem("material_modify_info")]
        public List<MaterialModifyInfo> MaterialList { get; set; }

        /// <summary>
        /// 前台类目名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
