using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// BusinessPropertyDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BusinessPropertyDTO : AopObject
    {
        /// <summary>
        /// 业务负责人工号
        /// </summary>
        [XmlElement("biz_owner_id")]
        public string BizOwnerId { get; set; }

        /// <summary>
        /// 所属业务画像id
        /// </summary>
        [XmlElement("business_profile_id")]
        public string BusinessProfileId { get; set; }

        /// <summary>
        /// 业务画像标签id
        /// </summary>
        [XmlElement("business_property_id")]
        public string BusinessPropertyId { get; set; }

        /// <summary>
        /// is_vip
        /// </summary>
        [XmlElement("column_name")]
        public string ColumnName { get; set; }

        /// <summary>
        /// 来源字段类型
        /// </summary>
        [XmlElement("column_type")]
        public string ColumnType { get; set; }

        /// <summary>
        /// 创建人工号
        /// </summary>
        [XmlElement("creator_id")]
        public string CreatorId { get; set; }

        /// <summary>
        /// 数据负责人工号
        /// </summary>
        [XmlElement("data_owner_id")]
        public string DataOwnerId { get; set; }

        /// <summary>
        /// 英文名称
        /// </summary>
        [XmlElement("english_name")]
        public string EnglishName { get; set; }

        /// <summary>
        /// 个性化信息
        /// </summary>
        [XmlArray("personality_info")]
        [XmlArrayItem("personality_info_d_t_o")]
        public List<PersonalityInfoDTO> PersonalityInfo { get; set; }

        /// <summary>
        /// 标签描述
        /// </summary>
        [XmlElement("property_desc")]
        public string PropertyDesc { get; set; }

        /// <summary>
        /// 标签名称
        /// </summary>
        [XmlElement("propery_name")]
        public string ProperyName { get; set; }

        /// <summary>
        /// 质量负责人工号
        /// </summary>
        [XmlElement("quality_owner_id")]
        public string QualityOwnerId { get; set; }

        /// <summary>
        /// 标签状态
        /// </summary>
        [XmlElement("stauts")]
        public string Stauts { get; set; }

        /// <summary>
        /// 来源表guid
        /// </summary>
        [XmlElement("table_guid")]
        public string TableGuid { get; set; }
    }
}
