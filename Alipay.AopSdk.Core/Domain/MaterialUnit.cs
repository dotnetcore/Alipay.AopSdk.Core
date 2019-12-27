using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MaterialUnit Data Structure.
    /// </summary>
    [Serializable]
    public class MaterialUnit : AopObject
    {
        /// <summary>
        /// 创意元素C端渲染关联位置key值
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 创意图片/视频物料URL；标题/描述文本值
        /// </summary>
        [XmlElement("material")]
        public string Material { get; set; }

        /// <summary>
        /// 创意元素类型，IMG-图片；VIDEO-视频；TITLE-标题；DESC-描述
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
