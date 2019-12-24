using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// Position Data Structure.
    /// </summary>
    [Serializable]
    public class Position : AopObject
    {
        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 点位唯一标识id
        /// </summary>
        [XmlElement("device_id")]
        public long DeviceId { get; set; }

        /// <summary>
        /// 屏幕类型，枚举值：SLCD、LED
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 公交 或者 地铁：SUBWAY、BUS
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 站点编码
        /// </summary>
        [XmlElement("station_code")]
        public string StationCode { get; set; }

        /// <summary>
        /// 站点等级，共分为4个等级，分别为：LEVELA、LEVLEB、LEVELC 以及 LEVELD
        /// </summary>
        [XmlElement("station_level")]
        public string StationLevel { get; set; }
    }
}
