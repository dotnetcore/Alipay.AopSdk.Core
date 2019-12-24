using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayPcreditLoanLoanInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditLoanLoanInfoQueryModel : AopObject
    {
        /// <summary>
        /// 代表了一次请求，作为业务幂等性控制
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
