using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayIserviceCognitiveInvoicesInferenceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCognitiveInvoicesInferenceQueryModel : AopObject
    {
        /// <summary>
        /// 图片文件类型，pdf或jpg，默认pdf
        /// </summary>
        [XmlElement("file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// 图片base64加密后的内容
        /// </summary>
        [XmlElement("img_content")]
        public string ImgContent { get; set; }
    }
}
