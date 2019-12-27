using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// CloudbusRoute Data Structure.
    /// </summary>
    [Serializable]
    public class CloudbusRoute : AopObject
    {
        /// <summary>
        /// 修改类型
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 线路方向：枚举 up  down
        /// </summary>
        [XmlElement("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 路线id
        /// </summary>
        [XmlElement("line_id")]
        public string LineId { get; set; }

        /// <summary>
        /// 公交路线轨迹
        /// </summary>
        [XmlArray("line_lon_lat")]
        [XmlArrayItem("cloudbus_location")]
        public List<CloudbusLocation> LineLonLat { get; set; }

        /// <summary>
        /// 线路名称(87 路-上行)
        /// </summary>
        [XmlElement("line_name")]
        public string LineName { get; set; }

        /// <summary>
        /// 运营时间
        /// </summary>
        [XmlArray("operation_time")]
        [XmlArrayItem("string")]
        public List<string> OperationTime { get; set; }

        /// <summary>
        /// 票价
        /// </summary>
        [XmlElement("price")]
        public long Price { get; set; }

        /// <summary>
        /// 站点
        /// </summary>
        [XmlArray("stops")]
        [XmlArrayItem("cloudbus_stop")]
        public List<CloudbusStop> Stops { get; set; }
    }
}
