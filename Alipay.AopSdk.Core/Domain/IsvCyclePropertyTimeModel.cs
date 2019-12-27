using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// IsvCyclePropertyTimeModel Data Structure.
    /// </summary>
    [Serializable]
    public class IsvCyclePropertyTimeModel : AopObject
    {
        /// <summary>
        /// 日期
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// * 周期属性时间类型  WEEK("WEEK", "星期"),  DATE("DATE", "日期"),
        /// </summary>
        [XmlElement("time_type")]
        public string TimeType { get; set; }

        /// <summary>
        /// 星期
        /// </summary>
        [XmlElement("week")]
        public string Week { get; set; }
    }
}
