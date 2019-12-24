using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// Roadinter Data Structure.
    /// </summary>
    [Serializable]
    public class Roadinter : AopObject
    {
        /// <summary>
        /// 输入点相对路口的方位
        /// </summary>
        [XmlElement("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 交叉路口到请求坐标的距离，单位是米
        /// </summary>
        [XmlElement("distance")]
        public string Distance { get; set; }

        /// <summary>
        /// 第一条道路id
        /// </summary>
        [XmlElement("first_id")]
        public string FirstId { get; set; }

        /// <summary>
        /// 第一条道路名称
        /// </summary>
        [XmlElement("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// 路口经纬度
        /// </summary>
        [XmlElement("location")]
        public string Location { get; set; }

        /// <summary>
        /// 第二条道路id
        /// </summary>
        [XmlElement("second_id")]
        public string SecondId { get; set; }

        /// <summary>
        /// 第二条道路名称
        /// </summary>
        [XmlElement("second_name")]
        public string SecondName { get; set; }
    }
}
