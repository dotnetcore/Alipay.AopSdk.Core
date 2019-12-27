using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// Building Data Structure.
    /// </summary>
    [Serializable]
    public class Building : AopObject
    {
        /// <summary>
        /// 建筑名称
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
