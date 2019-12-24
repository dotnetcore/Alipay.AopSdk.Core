using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayMarketingMaterialImageUploadResponse.
    /// </summary>
    public class AlipayMarketingMaterialImageUploadResponse : AopResponse
    {
        /// <summary>
        /// 图片唯一资源ID
        /// </summary>
        [XmlElement("resource_id")]
        public string ResourceId { get; set; }
    }
}
