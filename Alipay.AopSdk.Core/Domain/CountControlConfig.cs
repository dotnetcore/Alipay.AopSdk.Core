using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// CountControlConfig Data Structure.
    /// </summary>
    [Serializable]
    public class CountControlConfig : AopObject
    {
        /// <summary>
        /// 每天次数
        /// </summary>
        [XmlElement("day_count")]
        public long DayCount { get; set; }

        /// <summary>
        /// 计次维度, USER_ID 用户id, TERMINAL_ID 终端id, PHONE_NO 手机号，ID_CARD_NO 证件号
        /// </summary>
        [XmlElement("dimension")]
        public string Dimension { get; set; }

        /// <summary>
        /// 计次主题类型, CAMP_ACCESS 活动参与次数, CAMP_WIN 活动中奖次数
        /// </summary>
        [XmlElement("domain_type")]
        public string DomainType { get; set; }

        /// <summary>
        /// 终身次数
        /// </summary>
        [XmlElement("life_count")]
        public long LifeCount { get; set; }

        /// <summary>
        /// 每月次数
        /// </summary>
        [XmlElement("month_count")]
        public long MonthCount { get; set; }

        /// <summary>
        /// 每周次数
        /// </summary>
        [XmlElement("week_count")]
        public long WeekCount { get; set; }

        /// <summary>
        /// 每年次数
        /// </summary>
        [XmlElement("year_count")]
        public long YearCount { get; set; }
    }
}
