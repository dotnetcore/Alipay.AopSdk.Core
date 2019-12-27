using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayUserMemberAlipaycardQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserMemberAlipaycardQueryModel : AopObject
    {
        /// <summary>
        /// 缓存是否可用，手淘在请求前先查uid的缓存，新用户请求未落缓存或者上次缓存已经被清空时为false
        /// </summary>
        [XmlElement("available_cache")]
        public bool AvailableCache { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID，根据uid判别展示权益内容。由手淘直接传给支付宝
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
