using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// CloudbusPredictRItem Data Structure.
    /// </summary>
    [Serializable]
    public class CloudbusPredictRItem : AopObject
    {
        /// <summary>
        /// 站点轨迹
        /// </summary>
        [XmlArray("line_lon_lat")]
        [XmlArrayItem("cloudbus_location")]
        public List<CloudbusLocation> LineLonLat { get; set; }

        /// <summary>
        /// 运营时间
        /// </summary>
        [XmlArray("operation_time")]
        [XmlArrayItem("string")]
        public List<string> OperationTime { get; set; }

        /// <summary>
        /// 线路总客流
        /// </summary>
        [XmlElement("route_volume")]
        public long RouteVolume { get; set; }

        /// <summary>
        /// 11
        /// </summary>
        [XmlArray("stops")]
        [XmlArrayItem("cloudbus_stop")]
        public List<CloudbusStop> Stops { get; set; }
    }
}
