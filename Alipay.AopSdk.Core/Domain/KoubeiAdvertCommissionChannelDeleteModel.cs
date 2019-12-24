using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiAdvertCommissionChannelDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiAdvertCommissionChannelDeleteModel : AopObject
    {
        /// <summary>
        /// 需要删除的渠道ID列表
        /// </summary>
        [XmlArray("channel_ids")]
        [XmlArrayItem("string")]
        public List<string> ChannelIds { get; set; }
    }
}
