using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ZolozAuthenticationSmilepayInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZolozAuthenticationSmilepayInitializeModel : AopObject
    {
        /// <summary>
        /// 设备指纹，用于唯一标识一台设备
        /// </summary>
        [XmlElement("apdid_token")]
        public string ApdidToken { get; set; }

        /// <summary>
        /// 人脸识别应用名称
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 人脸识别应用版本号
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 基础包版本号
        /// </summary>
        [XmlElement("base_ver")]
        public string BaseVer { get; set; }

        /// <summary>
        /// 生物识别元信息
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
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public FaceExtParams ExtInfo { get; set; }

        /// <summary>
        /// 机具信息，调用人脸识别SDK获取
        /// </summary>
        [XmlElement("machine_info")]
        public FaceMachineInfo MachineInfo { get; set; }

        /// <summary>
        /// 商户信息
        /// </summary>
        [XmlElement("merchant_info")]
        public FaceMerchantInfo MerchantInfo { get; set; }

        /// <summary>
        /// 操作系统版本号
        /// </summary>
        [XmlElement("os_version")]
        public string OsVersion { get; set; }

        /// <summary>
        /// 业务ID
        /// </summary>
        [XmlElement("remote_log_id")]
        public string RemoteLogId { get; set; }

        /// <summary>
        /// ZIM版本号
        /// </summary>
        [XmlElement("zim_ver")]
        public string ZimVer { get; set; }
    }
}
