using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipaySecurityProdDfesfDefBatchqueryResponse.
    /// </summary>
    public class AlipaySecurityProdDfesfDefBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("ded")]
        public string Ded { get; set; }
    }
}
