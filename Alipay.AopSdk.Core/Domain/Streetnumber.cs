using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// Streetnumber Data Structure.
    /// </summary>
    [Serializable]
    public class Streetnumber : AopObject
    {
        /// <summary>
        /// 街道方向
        /// </summary>
        [XmlElement("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 门牌地址到请求坐标的距离
        /// </summary>
        [XmlElement("distance")]
        public string Distance { get; set; }

        /// <summary>
        /// 坐标点
        /// </summary>
        [XmlElement("location")]
        public string Location { get; set; }

        /// <summary>
        /// 门牌号
        /// </summary>
        [XmlElement("number")]
        public string Number { get; set; }

        /// <summary>
        /// 街道名称
        /// </summary>
        [XmlElement("street")]
        public string Street { get; set; }
    }
}
