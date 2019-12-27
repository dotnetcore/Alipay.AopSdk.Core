using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdCreativeQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdCreativeQueryResponse : AopResponse
    {
        /// <summary>
        /// 创意详情
        /// </summary>
        [XmlElement("creative_detail")]
        public CreativeDetail CreativeDetail { get; set; }
    }
}
