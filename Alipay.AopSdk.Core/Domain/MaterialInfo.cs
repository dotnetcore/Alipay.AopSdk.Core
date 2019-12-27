using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MaterialInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MaterialInfo : AopObject
    {
        /// <summary>
        /// 素材内容（素材地址或素材KEY）
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 素材ID
        /// </summary>
        [XmlElement("material_id")]
        public string MaterialId { get; set; }

        /// <summary>
        /// 素材类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
