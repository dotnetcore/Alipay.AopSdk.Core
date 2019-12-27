using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayBossFncInvoiceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncInvoiceQueryModel : AopObject
    {
        /// <summary>
        /// 查询ID：用于标示一张发票，通过发票综合查询可以查询到该ID。
        /// </summary>
        [XmlElement("invoice_id")]
        public string InvoiceId { get; set; }
    }
}
