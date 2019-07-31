using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ZolozIdentificationCustomerSmilerepoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZolozIdentificationCustomerSmilerepoSyncModel : AopObject
    {
        /// <summary>
        /// 活体图片encode base64 String
        /// </summary>
        [XmlElement("auth_img")]
        public string AuthImg { get; set; }

        /// <summary>
        /// 商户的机具编码
        /// </summary>
        [XmlElement("device_num")]
        public string DeviceNum { get; set; }

        /// <summary>
        /// 人脸定制分配的场景码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 人脸相关的比对结果信
        /// </summary>
        [XmlElement("zface_info")]
        public string ZfaceInfo { get; set; }
    }
}
