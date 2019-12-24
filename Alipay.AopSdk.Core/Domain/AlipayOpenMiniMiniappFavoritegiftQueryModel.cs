using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenMiniMiniappFavoritegiftQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniMiniappFavoritegiftQueryModel : AopObject
    {
        /// <summary>
        /// 收藏有礼查询每个小程序相关信息的列表
        /// </summary>
        [XmlArray("activity_list")]
        [XmlArrayItem("activity_query_info")]
        public List<ActivityQueryInfo> ActivityList { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
