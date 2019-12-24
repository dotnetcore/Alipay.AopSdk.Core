using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ZolozAuthenticationFaceInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZolozAuthenticationFaceInitializeModel : AopObject
    {
        /// <summary>
        /// apdidToken
        /// </summary>
        [XmlElement("apdid_token")]
        public string ApdidToken { get; set; }

        /// <summary>
        /// App名称
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// App版本
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// base version
        /// </summary>
        [XmlElement("base_ver")]
        public string BaseVer { get; set; }

        /// <summary>
        /// bioMetaInfo
        /// </summary>
        [XmlElement("bio_meta_info")]
        public string BioMetaInfo { get; set; }

        /// <summary>
        /// 设备型号
        /// </summary>
        [XmlElement("device_model")]
        public string DeviceModel { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// extInfo
        /// </summary>
        [XmlElement("ext_info")]
        public FaceExtParams ExtInfo { get; set; }

        /// <summary>
        /// FaceMachineInfo
        /// </summary>
        [XmlElement("machine_info")]
        public FaceMachineInfo MachineInfo { get; set; }

        /// <summary>
        /// FaceMerchantInfo
        /// </summary>
        [XmlElement("merchant_info")]
        public FaceMerchantInfo MerchantInfo { get; set; }

        /// <summary>
        /// 操作系统版本
        /// </summary>
        [XmlElement("os_version")]
        public string OsVersion { get; set; }

        /// <summary>
        /// 业务ID
        /// </summary>
        [XmlElement("remote_log_id")]
        public string RemoteLogId { get; set; }

        /// <summary>
        /// zim version
        /// </summary>
        [XmlElement("zim_ver")]
        public string ZimVer { get; set; }
    }
}
