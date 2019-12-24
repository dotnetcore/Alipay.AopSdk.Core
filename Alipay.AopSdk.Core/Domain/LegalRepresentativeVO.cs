using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// LegalRepresentativeVO Data Structure.
    /// </summary>
    [Serializable]
    public class LegalRepresentativeVO : AopObject
    {
        /// <summary>
        /// 职务
        /// </summary>
        [XmlElement("duty")]
        public string Duty { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
