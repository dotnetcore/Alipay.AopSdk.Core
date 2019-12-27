using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayCommerceAirXfgDsgModifyResponse.
    /// </summary>
    public class AlipayCommerceAirXfgDsgModifyResponse : AopResponse
    {
        /// <summary>
        /// 用户级别
        /// </summary>
        [XmlElement("level")]
        public string Level { get; set; }
    }
}
