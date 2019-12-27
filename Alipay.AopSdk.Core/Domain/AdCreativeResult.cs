using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AdCreativeResult Data Structure.
    /// </summary>
    [Serializable]
    public class AdCreativeResult : AopObject
    {
        /// <summary>
        /// 广告创意ID
        /// </summary>
        [XmlElement("ad_id")]
        public long AdId { get; set; }

        /// <summary>
        /// 创意包含的物料列表
        /// </summary>
        [XmlArray("ad_material_list")]
        [XmlArrayItem("ad_material_result_d_t_o")]
        public List<AdMaterialResultDTO> AdMaterialList { get; set; }

        /// <summary>
        /// 创意名称
        /// </summary>
        [XmlElement("ad_name")]
        public string AdName { get; set; }

        /// <summary>
        /// 创意审核状态，PASS：审核通过；TO_BE_AUDTI：待审核；OP_AUDIT：运营审核中；MEDIA_AUDIT：媒体审核中；REFUSED：审核拒绝
        /// </summary>
        [XmlElement("audit_status")]
        public string AuditStatus { get; set; }

        /// <summary>
        /// 所属广告单元ID
        /// </summary>
        [XmlElement("group_id")]
        public long GroupId { get; set; }

        /// <summary>
        /// 创意状态，ENABLE：生效；DISABLE：失效
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 创意使用模板名称
        /// </summary>
        [XmlElement("template_name")]
        public string TemplateName { get; set; }
    }
}
