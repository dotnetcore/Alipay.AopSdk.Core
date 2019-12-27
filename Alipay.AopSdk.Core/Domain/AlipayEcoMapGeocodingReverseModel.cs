using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayEcoMapGeocodingReverseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMapGeocodingReverseModel : AopObject
    {
        /// <summary>
        /// 渠道 0-高德地图 1-百度地图
        /// </summary>
        [XmlElement("channel")]
        public long Channel { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }
    }
}
