using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ExerciseItem Data Structure.
    /// </summary>
    [Serializable]
    public class ExerciseItem : AopObject
    {
        /// <summary>
        /// 项目描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 外部项目ID
        /// </summary>
        [XmlElement("external_item_id")]
        public string ExternalItemId { get; set; }

        /// <summary>
        /// 项目类型码
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 健身项目名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 父项目类型码
        /// </summary>
        [XmlElement("parent_item_code")]
        public string ParentItemCode { get; set; }
    }
}
