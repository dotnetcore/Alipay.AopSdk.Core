using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// BudgetVO Data Structure.
    /// </summary>
    [Serializable]
    public class BudgetVO : AopObject
    {
        /// <summary>
        /// 应还总金额 = 正常本金+逾期本金+正常利息+逾期利息+逾期本金罚息+逾期利息罚息
        /// </summary>
        [XmlElement("need_repay_total")]
        public string NeedRepayTotal { get; set; }

        /// <summary>
        /// 正常利息
        /// </summary>
        [XmlElement("nom_int")]
        public string NomInt { get; set; }

        /// <summary>
        /// 正常本金
        /// </summary>
        [XmlElement("nom_prin")]
        public string NomPrin { get; set; }

        /// <summary>
        /// 逾期利息
        /// </summary>
        [XmlElement("ovd_int")]
        public string OvdInt { get; set; }

        /// <summary>
        /// 逾期利息罚息
        /// </summary>
        [XmlElement("ovd_int_pen_int")]
        public string OvdIntPenInt { get; set; }

        /// <summary>
        /// 逾期本金
        /// </summary>
        [XmlElement("ovd_prin")]
        public string OvdPrin { get; set; }

        /// <summary>
        /// 逾期本金罚息
        /// </summary>
        [XmlElement("ovd_prin_pen_int")]
        public string OvdPrinPenInt { get; set; }
    }
}
