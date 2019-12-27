using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// Businessarea Data Structure.
    /// </summary>
    [Serializable]
    public class Businessarea : AopObject
    {
        /// <summary>
        /// 商圈所在区域的adcode
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 商圈中心点经纬度
        /// </summary>
        [XmlElement("location")]
        public string Location { get; set; }

        /// <summary>
        /// 商圈名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
