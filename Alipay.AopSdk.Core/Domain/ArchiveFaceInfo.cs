using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ArchiveFaceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ArchiveFaceInfo : AopObject
    {
        /// <summary>
        /// 人脸图片BASE64转换后字符串,大小限制为2M
        /// </summary>
        [XmlElement("face_image")]
        public string FaceImage { get; set; }

        /// <summary>
        /// 人脸图片类型,取值范围:  COMMERCIAL_PS_WITH_MASK 商业公安网带网纹人脸图片  HMT_PS 港澳台公安网
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 废弃
        /// </summary>
        [XmlElement("usable")]
        public bool Usable { get; set; }
    }
}
