using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiAdvertCommissionChannelModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiAdvertCommissionChannelModifyModel : AopObject
    {
        /// <summary>
        /// 修改渠道信息(新增、删除、修改渠道不可同时为空)
        /// </summary>
        [XmlArray("channels")]
        [XmlArrayItem("kb_advert_modify_channel_request")]
        public List<KbAdvertModifyChannelRequest> Channels { get; set; }
    }
}
