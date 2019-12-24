using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenMiniMiniappFavoriteAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniMiniappFavoriteAddModel : AopObject
    {
        /// <summary>
        /// 需要指定收藏的app_id，若开放平台分配的app_id与具体的小程序不同时，才需要传参
        /// </summary>
        [XmlElement("designated_app_id")]
        public string DesignatedAppId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
