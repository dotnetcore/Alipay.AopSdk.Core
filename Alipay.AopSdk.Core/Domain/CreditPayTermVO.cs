using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// CreditPayTermVO Data Structure.
    /// </summary>
    [Serializable]
    public class CreditPayTermVO : AopObject
    {
        /// <summary>
        /// 期限结束日期
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 开始日期
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 期数
        /// </summary>
        [XmlElement("term")]
        public long Term { get; set; }

        /// <summary>
        /// 期限单位
        /// </summary>
        [XmlElement("term_unit")]
        public string TermUnit { get; set; }
    }
}
