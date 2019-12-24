using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AdCreative Data Structure.
    /// </summary>
    [Serializable]
    public class AdCreative : AopObject
    {
        /// <summary>
        /// 广告物料包含的物料列表
        /// </summary>
        [XmlArray("ad_material_list")]
        [XmlArrayItem("ad_material")]
        public List<AdMaterial> AdMaterialList { get; set; }

        /// <summary>
        /// 创意名称
        /// </summary>
        [XmlElement("ad_name")]
        public string AdName { get; set; }

        /// <summary>
        /// 所属广告单元ID
        /// </summary>
        [XmlElement("group_id")]
        public long GroupId { get; set; }

        /// <summary>
        /// 创意使用模板ID
        /// </summary>
        [XmlElement("template_id")]
        public long TemplateId { get; set; }
    }
}
