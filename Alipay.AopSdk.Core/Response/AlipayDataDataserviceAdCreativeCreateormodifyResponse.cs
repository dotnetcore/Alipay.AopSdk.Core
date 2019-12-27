using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdCreativeCreateormodifyResponse.
    /// </summary>
    public class AlipayDataDataserviceAdCreativeCreateormodifyResponse : AopResponse
    {
        /// <summary>
        /// 广告投放平台生成的创意ID
        /// </summary>
        [XmlElement("creative_id")]
        public long CreativeId { get; set; }

        /// <summary>
        /// 外部平台导入广告库后，广告投放创意对应的外部资源ID
        /// </summary>
        [XmlElement("creative_outer_id")]
        public string CreativeOuterId { get; set; }
    }
}
