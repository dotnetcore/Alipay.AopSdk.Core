using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// PersonalityInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PersonalityInfoDTO : AopObject
    {
        /// <summary>
        /// 枚举名code
        /// </summary>
        [XmlElement("enum_code")]
        public string EnumCode { get; set; }

        /// <summary>
        /// 枚举ID
        /// </summary>
        [XmlElement("enum_id")]
        public string EnumId { get; set; }

        /// <summary>
        /// 枚举名称
        /// </summary>
        [XmlElement("enum_name")]
        public string EnumName { get; set; }

        /// <summary>
        /// 枚举值code
        /// </summary>
        [XmlElement("enum_value_code")]
        public string EnumValueCode { get; set; }

        /// <summary>
        /// 枚举值名称
        /// </summary>
        [XmlElement("enum_value_name")]
        public string EnumValueName { get; set; }
    }
}
