using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayOpenPublicShortlinkCreateResponse.
    /// </summary>
    public class AlipayOpenPublicShortlinkCreateResponse : AopResponse
    {
        /// <summary>
        /// 生成的带参推广短链接
        /// </summary>
        [XmlElement("shortlink")]
        public string Shortlink { get; set; }
    }
}
