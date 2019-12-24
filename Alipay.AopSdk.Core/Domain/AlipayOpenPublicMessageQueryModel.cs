using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenPublicMessageQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicMessageQueryModel : AopObject
    {
        /// <summary>
        /// 消息id集，限制最多传入20个message_id。message_id在调用群发、组发消息接口时会返回，需调用方保存
        /// </summary>
        [XmlArray("message_ids")]
        [XmlArrayItem("string")]
        public List<string> MessageIds { get; set; }
    }
}
