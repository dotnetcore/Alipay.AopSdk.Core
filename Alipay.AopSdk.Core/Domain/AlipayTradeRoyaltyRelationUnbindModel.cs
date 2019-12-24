using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayTradeRoyaltyRelationUnbindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeRoyaltyRelationUnbindModel : AopObject
    {
        /// <summary>
        /// 外部请求号。32个字符以内，可包含字母、数字、下划线。需保证在商户端不重复。
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 分账接收方列表，单次传入最多20个
        /// </summary>
        [XmlArray("receiver_list")]
        [XmlArrayItem("royalty_entity")]
        public List<RoyaltyEntity> ReceiverList { get; set; }
    }
}
