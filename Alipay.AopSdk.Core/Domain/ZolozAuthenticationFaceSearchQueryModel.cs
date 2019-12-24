using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ZolozAuthenticationFaceSearchQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZolozAuthenticationFaceSearchQueryModel : AopObject
    {
        /// <summary>
        /// 人脸图片采集后的加密字符串
        /// </summary>
        [XmlElement("blob")]
        public string Blob { get; set; }

        /// <summary>
        /// 商户设备编码
        /// </summary>
        [XmlElement("device_num")]
        public string DeviceNum { get; set; }

        /// <summary>
        /// 机具分组编码
        /// </summary>
        [XmlElement("group")]
        public string Group { get; set; }

        /// <summary>
        /// zim唯一标识
        /// </summary>
        [XmlElement("zim_id")]
        public string ZimId { get; set; }
    }
}
