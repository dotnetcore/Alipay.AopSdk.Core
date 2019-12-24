using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// NewsfeedMediaImg Data Structure.
    /// </summary>
    [Serializable]
    public class NewsfeedMediaImg : AopObject
    {
        /// <summary>
        /// 图片高度
        /// </summary>
        [XmlElement("height")]
        public string Height { get; set; }

        /// <summary>
        /// 图片地址
        /// </summary>
        [XmlElement("src")]
        public string Src { get; set; }

        /// <summary>
        /// 图片宽度
        /// </summary>
        [XmlElement("width")]
        public string Width { get; set; }
    }
}
