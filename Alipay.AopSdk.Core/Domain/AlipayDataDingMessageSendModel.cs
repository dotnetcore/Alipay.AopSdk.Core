using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayDataDingMessageSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDingMessageSendModel : AopObject
    {
        /// <summary>
        /// access_token
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 通知内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }
    }
}
