using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayOpenPublicAdvertCreateResponse.
    /// </summary>
    public class AlipayOpenPublicAdvertCreateResponse : AopResponse
    {
        /// <summary>
        /// 广告位id
        /// </summary>
        [XmlElement("advert_id")]
        public string AdvertId { get; set; }
    }
}
