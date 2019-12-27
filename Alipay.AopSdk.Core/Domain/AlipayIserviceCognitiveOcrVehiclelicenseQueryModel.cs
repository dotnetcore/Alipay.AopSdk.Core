using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayIserviceCognitiveOcrVehiclelicenseQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCognitiveOcrVehiclelicenseQueryModel : AopObject
    {
        /// <summary>
        /// 行驶证图片base64加密后内容，大小限制在1.5M
        /// </summary>
        [XmlElement("image_content")]
        public string ImageContent { get; set; }

        /// <summary>
        /// face: 行驶证正面 back: 行驶证副页 缺省值是：face
        /// </summary>
        [XmlElement("side")]
        public string Side { get; set; }
    }
}
