using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ExerciseDailySummaryOpenModel Data Structure.
    /// </summary>
    [Serializable]
    public class ExerciseDailySummaryOpenModel : AopObject
    {
        /// <summary>
        /// 时长：单位秒
        /// </summary>
        [XmlElement("duration")]
        public long Duration { get; set; }

        /// <summary>
        /// 目标类型:CARDIO，MUSCLE，FLEXIBILITY
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
