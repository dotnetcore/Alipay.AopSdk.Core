using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// StockHolderVO Data Structure.
    /// </summary>
    [Serializable]
    public class StockHolderVO : AopObject
    {
        /// <summary>
        /// 出资日期
        /// </summary>
        [XmlElement("invest_date")]
        public string InvestDate { get; set; }

        /// <summary>
        /// 出资比例(%)
        /// </summary>
        [XmlElement("invest_rate")]
        public string InvestRate { get; set; }

        /// <summary>
        /// 股东名称
        /// </summary>
        [XmlElement("org_holder_name")]
        public string OrgHolderName { get; set; }

        /// <summary>
        /// 股东类型
        /// </summary>
        [XmlElement("org_holder_type")]
        public string OrgHolderType { get; set; }

        /// <summary>
        /// 认缴额（万）
        /// </summary>
        [XmlElement("subscript_amt")]
        public string SubscriptAmt { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("subscript_amt_curcy")]
        public string SubscriptAmtCurcy { get; set; }
    }
}
