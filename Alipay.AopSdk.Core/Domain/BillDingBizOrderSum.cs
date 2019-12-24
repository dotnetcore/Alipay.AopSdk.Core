using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// BillDingBizOrderSum Data Structure.
    /// </summary>
    [Serializable]
    public class BillDingBizOrderSum : AopObject
    {
        /// <summary>
        /// 日期展示, 月份2018-07,日期2018-07-10
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 支出金额
        /// </summary>
        [XmlElement("expenses")]
        public string Expenses { get; set; }

        /// <summary>
        /// 收入金额
        /// </summary>
        [XmlElement("income")]
        public string Income { get; set; }
    }
}
