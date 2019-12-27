using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MeterOpenModel Data Structure.
    /// </summary>
    [Serializable]
    public class MeterOpenModel : AopObject
    {
        /// <summary>
        /// 平均速度，数字字符串，保留1位小数。type=AVG_SPEED_KM_PER_HOUR时必填
        /// </summary>
        [XmlElement("avg_speed")]
        public string AvgSpeed { get; set; }

        /// <summary>
        /// 项目消耗的卡路里，单位：kcal 。type=CALORIE时必填
        /// </summary>
        [XmlElement("calorie")]
        public long Calorie { get; set; }

        /// <summary>
        /// 距离，单位：米。type=DISTANCE时必填
        /// </summary>
        [XmlElement("distance")]
        public long Distance { get; set; }

        /// <summary>
        /// 时长，单位秒。type=DURATION时必填
        /// </summary>
        [XmlElement("duration")]
        public long Duration { get; set; }

        /// <summary>
        /// 每组次数。type=COUNT时必填
        /// </summary>
        [XmlElement("rep")]
        public long Rep { get; set; }

        /// <summary>
        /// 组数。type=COUNT时必填
        /// </summary>
        [XmlElement("set")]
        public long Set { get; set; }

        /// <summary>
        /// 计量单位类型.枚举：数量(COUNT),时长(DURATION),距离(DISTANCE),平均速度_千米每小时(AVG_SPEED_KM_PER_HOUR)
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
