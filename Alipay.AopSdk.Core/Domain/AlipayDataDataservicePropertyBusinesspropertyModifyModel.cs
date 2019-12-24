using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayDataDataservicePropertyBusinesspropertyModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataservicePropertyBusinesspropertyModifyModel : AopObject
    {
        /// <summary>
        /// 业务负责人工号
        /// </summary>
        [XmlElement("biz_owner_id")]
        public string BizOwnerId { get; set; }

        /// <summary>
        /// 业务画像消费类目id
        /// </summary>
        [XmlElement("business_profile_category_id")]
        public string BusinessProfileCategoryId { get; set; }

        /// <summary>
        /// 业务画像标签id
        /// </summary>
        [XmlElement("business_property_id")]
        public string BusinessPropertyId { get; set; }

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
        /// 数据类型 NUMBER("数值型"), STRING("文本型"), DATE("日期型"), ENUM("枚举型"), LBS("经纬度类");
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 当数据类型为枚举型时，要指定枚举ID
        /// </summary>
        [XmlElement("enum_id")]
        public string EnumId { get; set; }

        /// <summary>
        /// 个性化信息，jsonarray字符串
        /// </summary>
        [XmlArray("personality_info")]
        [XmlArrayItem("string")]
        public List<string> PersonalityInfo { get; set; }

        /// <summary>
        /// 统计类型 ETL("ETL统计"), MODEL("模型预测")
        /// </summary>
        [XmlElement("proc_type")]
        public string ProcType { get; set; }

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
    }
}
