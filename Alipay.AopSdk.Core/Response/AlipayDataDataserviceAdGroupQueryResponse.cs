using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdGroupQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdGroupQueryResponse : AopResponse
    {
        /// <summary>
        /// 单元详情
        /// </summary>
        [XmlElement("group_detail")]
        public OuterGroup GroupDetail { get; set; }
    }
}
