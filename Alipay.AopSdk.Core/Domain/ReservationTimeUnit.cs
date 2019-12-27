using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ReservationTimeUnit Data Structure.
    /// </summary>
    [Serializable]
    public class ReservationTimeUnit : AopObject
    {
        /// <summary>
        /// 时间，格式HH:mm
        /// </summary>
        [XmlElement("time")]
        public string Time { get; set; }

        /// <summary>
        /// 当日CURRENT_DAY  次日NEXT_DAY
        /// </summary>
        [XmlElement("time_type")]
        public string TimeType { get; set; }
    }
}
