using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayOpenPublicMessageQueryResponse.
    /// </summary>
    public class AlipayOpenPublicMessageQueryResponse : AopResponse
    {
        /// <summary>
        /// 发送消息结果集。仅返回该用户已发送的消息
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("public_message_info")]
        public List<PublicMessageInfo> List { get; set; }
    }
}
