using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ImageInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ImageInfo : AopObject
    {
        /// <summary>
        /// 图片aftsId或者url
        /// </summary>
        [XmlElement("image")]
        public string Image { get; set; }

        /// <summary>
        /// 传入图片类型
        /// </summary>
        [XmlElement("image_type")]
        public string ImageType { get; set; }

        /// <summary>
        /// 图片数据md5值
        /// </summary>
        [XmlElement("md_5")]
        public string Md5 { get; set; }

        /// <summary>
        /// 图片数据标识名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
