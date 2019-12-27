using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// CustScpInstallmentBudgetVO Data Structure.
    /// </summary>
    [Serializable]
    public class CustScpInstallmentBudgetVO : AopObject
    {
        /// <summary>
        /// 是否可以还款
        /// </summary>
        [XmlElement("can_repay")]
        public bool CanRepay { get; set; }

        /// <summary>
        /// 分期到期日
        /// </summary>
        [XmlElement("due_date")]
        public string DueDate { get; set; }

        /// <summary>
        /// 分期编号
        /// </summary>
        [XmlElement("install_num")]
        public long InstallNum { get; set; }

        /// <summary>
        /// 账期开始日
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 分期状态 OVD:逾期状态,NOR:正常状态, CLR:结清状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 分期金额明细
        /// </summary>
        [XmlElement("term_amt_detail")]
        public CustScpBillAmtVO TermAmtDetail { get; set; }

        /// <summary>
        /// 分期总金额
        /// </summary>
        [XmlElement("term_total_amt")]
        public string TermTotalAmt { get; set; }
    }
}
