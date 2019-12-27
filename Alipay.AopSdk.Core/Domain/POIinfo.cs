using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// POIinfo Data Structure.
    /// </summary>
    [Serializable]
    public class POIinfo : AopObject
    {
        /// <summary>
        /// poi地址信息
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// POI所在商圈名称
        /// </summary>
        [XmlElement("businessarea")]
        public string Businessarea { get; set; }

        /// <summary>
        /// 输入点相对POI的方位
        /// </summary>
        [XmlElement("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 该POI到请求坐标的距离
        /// </summary>
        [XmlElement("distance")]
        public string Distance { get; set; }

        /// <summary>
        /// POI的id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// POI中心点的坐标
        /// </summary>
        [XmlElement("location")]
        public string Location { get; set; }

        /// <summary>
        /// POI名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        [XmlElement("tel")]
        public string Tel { get; set; }

        /// <summary>
        /// POI的类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
