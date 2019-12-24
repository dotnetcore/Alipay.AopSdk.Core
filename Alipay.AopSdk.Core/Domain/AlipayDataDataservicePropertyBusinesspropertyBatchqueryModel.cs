using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayDataDataservicePropertyBusinesspropertyBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataservicePropertyBusinesspropertyBatchqueryModel : AopObject
    {
        /// <summary>
        /// 业务画像id
        /// </summary>
        [XmlElement("business_profile_id")]
        public string BusinessProfileId { get; set; }

        /// <summary>
        /// 业务画像标签id列表，逗号分隔
        /// </summary>
        [XmlArray("business_property_ids")]
        [XmlArrayItem("string")]
        public List<string> BusinessPropertyIds { get; set; }

        /// <summary>
        /// 业务画像标签对应的columnGuid
        /// </summary>
        [XmlElement("column_guid")]
        public string ColumnGuid { get; set; }

        /// <summary>
        /// 标签名称
        /// </summary>
        [XmlElement("property_name")]
        public string PropertyName { get; set; }

        /// <summary>
        /// 标签状态，逗号分隔
        /// </summary>
        [XmlArray("status")]
        [XmlArrayItem("string")]
        public List<string> Status { get; set; }

        /// <summary>
        /// 业务画像标签对应的tableGuid
        /// </summary>
        [XmlElement("table_guid")]
        public string TableGuid { get; set; }
    }
}
