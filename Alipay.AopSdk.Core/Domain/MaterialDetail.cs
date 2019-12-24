using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MaterialDetail Data Structure.
    /// </summary>
    [Serializable]
    public class MaterialDetail : AopObject
    {
        /// <summary>
        /// 广告投放平台生成的物料ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 创意元素C端渲染关联位置key值
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 物料元素类型，IMG-图片；VIDEO-视频
        /// </summary>
        [XmlElement("material_type")]
        public string MaterialType { get; set; }

        /// <summary>
        /// 创意图片/视频物料元素URL
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
