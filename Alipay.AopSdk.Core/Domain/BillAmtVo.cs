using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// BillAmtVo Data Structure.
    /// </summary>
    [Serializable]
    public class BillAmtVo : AopObject
    {
        /// <summary>
        /// 利息
        /// </summary>
        [XmlElement("int_amt")]
        public MultiCurrencyMoneyVO IntAmt { get; set; }

        /// <summary>
        /// 逾期利息
        /// </summary>
        [XmlElement("ovd_int_amt")]
        public MultiCurrencyMoneyVO OvdIntAmt { get; set; }

        /// <summary>
        /// 本罚
        /// </summary>
        [XmlElement("ovd_prin_amt")]
        public MultiCurrencyMoneyVO OvdPrinAmt { get; set; }

        /// <summary>
        /// 罚息
        /// </summary>
        [XmlElement("pen_int_amt")]
        public MultiCurrencyMoneyVO PenIntAmt { get; set; }

        /// <summary>
        /// 本罚
        /// </summary>
        [XmlElement("pen_prin_amt")]
        public MultiCurrencyMoneyVO PenPrinAmt { get; set; }

        /// <summary>
        /// 本金
        /// </summary>
        [XmlElement("prin_amt")]
        public MultiCurrencyMoneyVO PrinAmt { get; set; }
    }
}
