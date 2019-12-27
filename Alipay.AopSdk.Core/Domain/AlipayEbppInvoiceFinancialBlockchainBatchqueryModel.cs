using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceFinancialBlockchainBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceFinancialBlockchainBatchqueryModel : AopObject
    {
        /// <summary>
        /// 证件号码的hash值，使用MD5算法获取的hash
        /// </summary>
        [XmlElement("cert_no_hash")]
        public string CertNoHash { get; set; }

        /// <summary>
        /// 证件类型  可选值（身份证：IDENTITY_CARD）
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 当前页码，起始号码是1
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 票据种类  可选值（财政电子票据：FINANCIAL_ELECTRONIC_BILL）
        /// </summary>
        [XmlElement("invoice_kind")]
        public string InvoiceKind { get; set; }

        /// <summary>
        /// 分页大小，最大值为50
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
