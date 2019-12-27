using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// Neighborhood Data Structure.
    /// </summary>
    [Serializable]
    public class Neighborhood : AopObject
    {
        /// <summary>
        /// 社区名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// POI类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
