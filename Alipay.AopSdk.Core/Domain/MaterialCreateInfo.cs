using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MaterialCreateInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MaterialCreateInfo : AopObject
    {
        /// <summary>
        /// 素材内容（素材地址或素材KEY）
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 素材类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
