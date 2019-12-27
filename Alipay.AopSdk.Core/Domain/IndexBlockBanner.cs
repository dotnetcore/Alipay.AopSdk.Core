using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// IndexBlockBanner Data Structure.
    /// </summary>
    [Serializable]
    public class IndexBlockBanner : AopObject
    {
        /// <summary>
        /// 图片地址，展示需要的图片信息
        /// </summary>
        [XmlElement("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 特殊落地页,如果这里没值,会跳到栏目的二级页
        /// </summary>
        [XmlElement("jump_url")]
        public string JumpUrl { get; set; }
    }
}
