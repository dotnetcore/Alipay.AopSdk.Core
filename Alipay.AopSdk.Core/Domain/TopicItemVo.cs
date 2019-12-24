using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// TopicItemVo Data Structure.
    /// </summary>
    [Serializable]
    public class TopicItemVo : AopObject
    {
        /// <summary>
        /// 话题描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 话题ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 0 正常状态，可使用;   -1 下线，不可使用。
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 话题标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
