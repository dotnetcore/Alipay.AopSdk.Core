using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// CloudbusRouteRItem Data Structure.
    /// </summary>
    [Serializable]
    public class CloudbusRouteRItem : AopObject
    {
        /// <summary>
        /// 线路变更后结果
        /// </summary>
        [XmlElement("after")]
        public CloudbusPredictRItem After { get; set; }

        /// <summary>
        /// 线路变更前线路信息
        /// </summary>
        [XmlElement("before")]
        public CloudbusPredictRItem Before { get; set; }

        /// <summary>
        /// 线路方向
        /// </summary>
        [XmlElement("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 线路id
        /// </summary>
        [XmlElement("line_id")]
        public string LineId { get; set; }

        /// <summary>
        /// 线路名称(87 路-上行)
        /// </summary>
        [XmlElement("line_name")]
        public string LineName { get; set; }
    }
}
