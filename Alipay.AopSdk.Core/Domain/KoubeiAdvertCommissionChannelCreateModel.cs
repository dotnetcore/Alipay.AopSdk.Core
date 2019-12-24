using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiAdvertCommissionChannelCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiAdvertCommissionChannelCreateModel : AopObject
    {
        /// <summary>
        /// 新增渠道列表
        /// </summary>
        [XmlArray("channels")]
        [XmlArrayItem("kb_advert_add_channel_request")]
        public List<KbAdvertAddChannelRequest> Channels { get; set; }
    }
}
