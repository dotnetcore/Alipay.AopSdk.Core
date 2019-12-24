using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AudioEvent Data Structure.
    /// </summary>
    [Serializable]
    public class AudioEvent : AopObject
    {
        /// <summary>
        /// 语音id, 也就是语音合成接口返回的audio_id
        /// </summary>
        [XmlElement("audio_id")]
        public string AudioId { get; set; }

        /// <summary>
        /// 播报语音的结束时间,标准时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 播报语音的开始时间,标准时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
