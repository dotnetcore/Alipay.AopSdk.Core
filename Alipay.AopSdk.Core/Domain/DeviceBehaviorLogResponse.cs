using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// DeviceBehaviorLogResponse Data Structure.
    /// </summary>
    [Serializable]
    public class DeviceBehaviorLogResponse : AopObject
    {
        /// <summary>
        /// 行为日志类型，SCAN_CDOE:扫码/HEARTBEAT:心跳
        /// </summary>
        [XmlElement("behavior_type")]
        public string BehaviorType { get; set; }

        /// <summary>
        /// 日志对应的设备信息
        /// </summary>
        [XmlElement("log_content")]
        public string LogContent { get; set; }

        /// <summary>
        /// 日志时间
        /// </summary>
        [XmlElement("log_time")]
        public string LogTime { get; set; }
    }
}
