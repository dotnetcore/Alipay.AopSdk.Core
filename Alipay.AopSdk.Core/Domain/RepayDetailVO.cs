using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// RepayDetailVO Data Structure.
    /// </summary>
    [Serializable]
    public class RepayDetailVO : AopObject
    {
        /// <summary>
        /// 归还利息
        /// </summary>
        [XmlElement("paid_int_amt")]
        public string PaidIntAmt { get; set; }

        /// <summary>
        /// 归还逾期利息
        /// </summary>
        [XmlElement("paid_ovd_int_amt")]
        public string PaidOvdIntAmt { get; set; }

        /// <summary>
        /// 归还逾期利息罚息
        /// </summary>
        [XmlElement("paid_ovd_int_penalty_amt")]
        public string PaidOvdIntPenaltyAmt { get; set; }

        /// <summary>
        /// 归还逾期本金
        /// </summary>
        [XmlElement("paid_ovd_prin_amt")]
        public string PaidOvdPrinAmt { get; set; }

        /// <summary>
        /// 归还逾期本金罚息
        /// </summary>
        [XmlElement("paid_ovd_prin_penalty_amt")]
        public string PaidOvdPrinPenaltyAmt { get; set; }

        /// <summary>
        /// 归还本金
        /// </summary>
        [XmlElement("paid_prin_amt")]
        public string PaidPrinAmt { get; set; }

        /// <summary>
        /// 还款总金额
        /// </summary>
        [XmlElement("repay_amt_total")]
        public string RepayAmtTotal { get; set; }

        /// <summary>
        /// 还款时间
        /// </summary>
        [XmlElement("repay_date")]
        public string RepayDate { get; set; }
    }
}
