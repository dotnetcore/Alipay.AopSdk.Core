using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayOpenPublicXwbtestabcdBatchqueryResponse.
    /// </summary>
    public class AlipayOpenPublicXwbtestabcdBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 1111
        /// </summary>
        [XmlElement("b")]
        public string B { get; set; }
    }
}
