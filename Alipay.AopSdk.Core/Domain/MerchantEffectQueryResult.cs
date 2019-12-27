using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MerchantEffectQueryResult Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantEffectQueryResult : AopObject
    {
        /// <summary>
        /// 累计充值笔数
        /// </summary>
        [XmlElement("accumulative_recharge_nums")]
        public string AccumulativeRechargeNums { get; set; }

        /// <summary>
        /// 累计到该天的补贴
        /// </summary>
        [XmlElement("accumulative_total_allowance")]
        public string AccumulativeTotalAllowance { get; set; }

        /// <summary>
        /// 累计开启天数
        /// </summary>
        [XmlElement("accumulative_total_days")]
        public string AccumulativeTotalDays { get; set; }

        /// <summary>
        /// 累计到该天的收入
        /// </summary>
        [XmlElement("accumulative_total_income")]
        public string AccumulativeTotalIncome { get; set; }

        /// <summary>
        /// 平均充值/赠送比(单位为分)
        /// </summary>
        [XmlElement("average_recharge_allowance_rate")]
        public string AverageRechargeAllowanceRate { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 有效收入增收
        /// </summary>
        [XmlElement("effective_increased_income")]
        public string EffectiveIncreasedIncome { get; set; }

        /// <summary>
        /// 累计商户有效收入
        /// </summary>
        [XmlElement("increased_income")]
        public string IncreasedIncome { get; set; }

        /// <summary>
        /// 当天商户补贴
        /// </summary>
        [XmlElement("merchant_allowance")]
        public string MerchantAllowance { get; set; }

        /// <summary>
        /// 当天商户收入
        /// </summary>
        [XmlElement("merchant_income")]
        public string MerchantIncome { get; set; }

        /// <summary>
        /// 核销率
        /// </summary>
        [XmlElement("use_rate")]
        public string UseRate { get; set; }
    }
}
