using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// LocationInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LocationInfo : AopObject
    {
        /// <summary>
        /// 用户所处的经度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 用户当前的纬度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 国家统一行政编码
        /// </summary>
        [XmlElement("region_code")]
        public string RegionCode { get; set; }
    }
}
