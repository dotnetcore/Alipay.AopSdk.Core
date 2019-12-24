using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// NextUrl Data Structure.
    /// </summary>
    [Serializable]
    public class NextUrl : AopObject
    {
        /// <summary>
        /// 小宝账户详情页跳转链接
        /// </summary>
        [XmlElement("jump_url")]
        public string JumpUrl { get; set; }

        /// <summary>
        /// 跳转链接的展示文案
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
