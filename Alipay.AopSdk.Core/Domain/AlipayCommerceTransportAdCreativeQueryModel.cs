using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayCommerceTransportAdCreativeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportAdCreativeQueryModel : AopObject
    {
        /// <summary>
        /// 广告主唯一ID；是否唯一(不需要)；用作校验防止跨user操作；天猫接口调用传参
        /// </summary>
        [XmlElement("ad_user_id")]
        public long AdUserId { get; set; }

        /// <summary>
        /// 广告创意ID；是否唯一(不需要)；用于通过创意ID查询创意详情；天猫广告创意信息查询入参
        /// </summary>
        [XmlElement("creative_id")]
        public long CreativeId { get; set; }
    }
}
