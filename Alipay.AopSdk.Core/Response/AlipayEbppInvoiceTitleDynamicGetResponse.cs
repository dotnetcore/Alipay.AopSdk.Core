using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayEbppInvoiceTitleDynamicGetResponse.
    /// </summary>
    public class AlipayEbppInvoiceTitleDynamicGetResponse : AopResponse
    {
        /// <summary>
        /// 发票抬头
        /// </summary>
        [XmlElement("title")]
        public InvoiceTitleModel Title { get; set; }
    }
}
