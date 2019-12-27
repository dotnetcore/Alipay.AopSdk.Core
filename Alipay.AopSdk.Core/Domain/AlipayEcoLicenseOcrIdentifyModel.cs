using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayEcoLicenseOcrIdentifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoLicenseOcrIdentifyModel : AopObject
    {
        /// <summary>
        /// 图片字节byte[]经过base64处理的字符串
        /// </summary>
        [XmlElement("image")]
        public string Image { get; set; }
    }
}
