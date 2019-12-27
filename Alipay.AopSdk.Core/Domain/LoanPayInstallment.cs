using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// LoanPayInstallment Data Structure.
    /// </summary>
    [Serializable]
    public class LoanPayInstallment : AopObject
    {
        /// <summary>
        /// 摘要要素，为JSON大字段
        /// </summary>
        [XmlElement("base_element")]
        public string BaseElement { get; set; }

        /// <summary>
        /// 分期要素详情，为JSON大字段
        /// </summary>
        [XmlElement("details_element")]
        public string DetailsElement { get; set; }

        /// <summary>
        /// 扩展要素，为JSONArray大字段
        /// </summary>
        [XmlElement("extends_element")]
        public string ExtendsElement { get; set; }

        /// <summary>
        /// 分期id
        /// </summary>
        [XmlElement("installment_id")]
        public string InstallmentId { get; set; }
    }
}
