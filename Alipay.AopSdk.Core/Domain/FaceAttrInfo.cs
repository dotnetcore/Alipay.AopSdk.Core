using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// FaceAttrInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FaceAttrInfo : AopObject
    {
        /// <summary>
        /// left,top,width,height 人脸图片中的人脸框的左上点和宽高，图片内坐标，无需脱敏
        /// </summary>
        [XmlElement("rect")]
        public string Rect { get; set; }
    }
}
