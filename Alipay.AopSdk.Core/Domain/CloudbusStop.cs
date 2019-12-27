using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// CloudbusStop Data Structure.
    /// </summary>
    [Serializable]
    public class CloudbusStop : AopObject
    {
        /// <summary>
        /// 维度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 站点id
        /// </summary>
        [XmlElement("station_id")]
        public string StationId { get; set; }

        /// <summary>
        /// 站点名称
        /// </summary>
        [XmlElement("station_name")]
        public string StationName { get; set; }

        /// <summary>
        /// 站点在线路内的序号
        /// </summary>
        [XmlElement("station_num")]
        public long StationNum { get; set; }

        /// <summary>
        /// 站间距
        /// </summary>
        [XmlElement("station_space")]
        public long StationSpace { get; set; }

        /// <summary>
        /// 站点客流
        /// </summary>
        [XmlElement("station_volume")]
        public long StationVolume { get; set; }
    }
}
