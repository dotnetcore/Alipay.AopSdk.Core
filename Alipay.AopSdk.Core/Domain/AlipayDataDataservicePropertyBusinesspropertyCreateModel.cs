using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayDataDataservicePropertyBusinesspropertyCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataservicePropertyBusinesspropertyCreateModel : AopObject
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
        /// 业务画像ID
        /// </summary>
        [XmlElement("business_profile_id")]
        public string BusinessProfileId { get; set; }

        /// <summary>
        /// 来源字段名
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
        /// 物理数据源类型 ODPS, HBASE, KUDU, ANTMETA, XVIEW, ANT_HBASE, EXPLOER;
        /// </summary>
        [XmlElement("physical_type")]
        public string PhysicalType { get; set; }

        /// <summary>
        /// 主键
        /// </summary>
        [XmlElement("primary_key")]
        public string PrimaryKey { get; set; }

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

        /// <summary>
        /// 标签来源渠道 TABLE("数据表"), FILE("文件"), INTERFACE("接口"), OBJECT_PROPERTY("公域标签")
        /// </summary>
        [XmlElement("source_channel")]
        public string SourceChannel { get; set; }

        /// <summary>
        /// 来源表guid
        /// </summary>
        [XmlElement("table_guid")]
        public string TableGuid { get; set; }
    }
}
