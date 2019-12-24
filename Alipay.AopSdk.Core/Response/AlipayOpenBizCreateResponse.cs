using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayOpenBizCreateResponse.
    /// </summary>
    public class AlipayOpenBizCreateResponse : AopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("a")]
        public string A { get; set; }

        /// <summary>
        /// 211
        /// </summary>
        [XmlElement("b")]
        public GavintestNewonline B { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("c")]
        public string C { get; set; }
    }
}
