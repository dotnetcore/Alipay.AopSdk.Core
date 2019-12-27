using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// FeedbackSubItem Data Structure.
    /// </summary>
    [Serializable]
    public class FeedbackSubItem : AopObject
    {
        /// <summary>
        /// 评价子项的评分
        /// </summary>
        [XmlElement("score")]
        public string Score { get; set; }

        /// <summary>
        /// 评价子项的描述
        /// </summary>
        [XmlElement("sub_item_desc")]
        public string SubItemDesc { get; set; }

        /// <summary>
        /// 评价子项的key
        /// </summary>
        [XmlElement("sub_item_key")]
        public string SubItemKey { get; set; }
    }
}
