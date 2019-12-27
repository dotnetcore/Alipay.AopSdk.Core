using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AntfortuneContentCommunityHoteventListQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneContentCommunityHoteventListQueryModel : AopObject
    {
        /// <summary>
        /// 某天的热门事件
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }

        /// <summary>
        /// 热门事件榜单的topn数量
        /// </summary>
        [XmlElement("topn_count")]
        public long TopnCount { get; set; }
    }
}
