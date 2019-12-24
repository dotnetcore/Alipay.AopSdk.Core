using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// PreRepayPlanTermVO Data Structure.
    /// </summary>
    [Serializable]
    public class PreRepayPlanTermVO : AopObject
    {
        /// <summary>
        /// 当期利息
        /// </summary>
        [XmlElement("int_bal")]
        public string IntBal { get; set; }

        /// <summary>
        /// 当期本金
        /// </summary>
        [XmlElement("prin_bal")]
        public string PrinBal { get; set; }

        /// <summary>
        /// 当期应还总额=当期本金+当期利息
        /// </summary>
        [XmlElement("repay_amt_total")]
        public string RepayAmtTotal { get; set; }

        /// <summary>
        /// 本期到期日，即应还款日期
        /// </summary>
        [XmlElement("term_end_date")]
        public string TermEndDate { get; set; }

        /// <summary>
        /// 期次号
        /// </summary>
        [XmlElement("term_no")]
        public long TermNo { get; set; }
    }
}
