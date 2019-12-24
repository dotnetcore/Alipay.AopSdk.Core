using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// CreditPayIntPricingVO Data Structure.
    /// </summary>
    [Serializable]
    public class CreditPayIntPricingVO : AopObject
    {
        /// <summary>
        /// 实际日利率，百分比形式
        /// </summary>
        [XmlElement("actual_day_int_rate")]
        public string ActualDayIntRate { get; set; }

        /// <summary>
        /// 实际利息，单位元
        /// </summary>
        [XmlElement("actual_int")]
        public string ActualInt { get; set; }

        /// <summary>
        /// 实际利率，小数形式
        /// </summary>
        [XmlElement("actual_int_rate")]
        public string ActualIntRate { get; set; }

        /// <summary>
        /// 分段利率
        /// </summary>
        [XmlArray("day_range_pricing_list")]
        [XmlArrayItem("credit_pay_day_range_pricing_v_o")]
        public List<CreditPayDayRangePricingVO> DayRangePricingList { get; set; }

        /// <summary>
        /// 原始日利率，百分比形式
        /// </summary>
        [XmlElement("origin_day_int_rate")]
        public string OriginDayIntRate { get; set; }

        /// <summary>
        /// 原始利息，单位元
        /// </summary>
        [XmlElement("origin_int")]
        public string OriginInt { get; set; }

        /// <summary>
        /// 原始利率，小数形式
        /// </summary>
        [XmlElement("origin_int_rate")]
        public string OriginIntRate { get; set; }
    }
}
