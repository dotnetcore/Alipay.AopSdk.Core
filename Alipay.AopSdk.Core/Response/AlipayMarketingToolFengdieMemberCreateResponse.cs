using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieMemberCreateResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieMemberCreateResponse : AopResponse
    {
        /// <summary>
        /// 凤蝶业务空间创建成功后，返回该成员的基本信息
        /// </summary>
        [XmlElement("data")]
        public FengdieSpaceMemberCreateModel Data { get; set; }
    }
}
