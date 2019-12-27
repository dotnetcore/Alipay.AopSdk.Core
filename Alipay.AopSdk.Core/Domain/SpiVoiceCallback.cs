using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// SpiVoiceCallback Data Structure.
    /// </summary>
    [Serializable]
    public class SpiVoiceCallback : AopObject
    {
        /// <summary>
        /// 阿里云语音编号
        /// </summary>
        [XmlElement("call_id")]
        public string CallId { get; set; }

        /// <summary>
        /// 被叫电话
        /// </summary>
        [XmlElement("callee")]
        public string Callee { get; set; }

        /// <summary>
        /// 通话时间
        /// </summary>
        [XmlElement("duration")]
        public long Duration { get; set; }

        /// <summary>
        /// 通话结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 数立内部业务编号
        /// </summary>
        [XmlElement("out_id")]
        public string OutId { get; set; }

        /// <summary>
        /// 通话开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 语音状态：200000-用户听完语音;200001-用户提前挂机未完整收听;200002-用户占线
        /// </summary>
        [XmlElement("status_code")]
        public string StatusCode { get; set; }
    }
}
