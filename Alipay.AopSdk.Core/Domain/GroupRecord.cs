using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// GroupRecord Data Structure.
    /// </summary>
    [Serializable]
    public class GroupRecord : AopObject
    {
        /// <summary>
        /// 本次返回的结果数量
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 展位ID，finetinyapp：精品小程序 finecard：场景card
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 显示名称，可为空
        /// </summary>
        [XmlElement("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 是否还有更多结果
        /// </summary>
        [XmlElement("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 命中结果
        /// </summary>
        [XmlArray("hits")]
        [XmlArrayItem("hit")]
        public List<Hit> Hits { get; set; }

        /// <summary>
        /// 更多显示名称
        /// </summary>
        [XmlElement("more_link_name")]
        public string MoreLinkName { get; set; }

        /// <summary>
        /// 更多url
        /// </summary>
        [XmlElement("more_link_url")]
        public string MoreLinkUrl { get; set; }

        /// <summary>
        /// 搜索命中结果总数量
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
