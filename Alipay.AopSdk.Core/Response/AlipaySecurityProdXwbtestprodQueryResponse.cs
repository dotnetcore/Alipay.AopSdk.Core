using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipaySecurityProdXwbtestprodQueryResponse.
    /// </summary>
    public class AlipaySecurityProdXwbtestprodQueryResponse : AopResponse
    {
        /// <summary>
        /// 11000
        /// </summary>
        [XmlElement("out_a")]
        public string OutA { get; set; }

        /// <summary>
        /// xxxx
        /// </summary>
        [XmlElement("out_b")]
        public long OutB { get; set; }
    }
}
