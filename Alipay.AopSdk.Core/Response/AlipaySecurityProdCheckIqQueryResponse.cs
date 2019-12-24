using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipaySecurityProdCheckIqQueryResponse.
    /// </summary>
    public class AlipaySecurityProdCheckIqQueryResponse : AopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("a")]
        public string A { get; set; }
    }
}
