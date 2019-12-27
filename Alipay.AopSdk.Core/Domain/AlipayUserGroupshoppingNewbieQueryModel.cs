using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayUserGroupshoppingNewbieQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserGroupshoppingNewbieQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝淘宝拼团的组团id
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 淘宝支付宝拼团的商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
