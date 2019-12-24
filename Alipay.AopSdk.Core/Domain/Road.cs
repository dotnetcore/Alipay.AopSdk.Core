using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// Road Data Structure.
    /// </summary>
    [Serializable]
    public class Road : AopObject
    {
        /// <summary>
        /// 输入点和此路的相对方位
        /// </summary>
        [XmlElement("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 道路到请求坐标的距离
        /// </summary>
        [XmlElement("distance")]
        public string Distance { get; set; }

        /// <summary>
        /// 道路ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 道路的中心点
        /// </summary>
        [XmlElement("location")]
        public string Location { get; set; }

        /// <summary>
        /// 道路名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
