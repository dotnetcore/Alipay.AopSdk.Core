using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// FaceMachineInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FaceMachineInfo : AopObject
    {
        /// <summary>
        /// 摄像头驱动版本号
        /// </summary>
        [XmlElement("camera_drive_ver")]
        public string CameraDriveVer { get; set; }

        /// <summary>
        /// 摄像头型号
        /// </summary>
        [XmlElement("camera_model")]
        public string CameraModel { get; set; }

        /// <summary>
        /// 摄像头名称
        /// </summary>
        [XmlElement("camera_name")]
        public string CameraName { get; set; }

        /// <summary>
        /// 摄像头版本号
        /// </summary>
        [XmlElement("camera_ver")]
        public string CameraVer { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext")]
        public string Ext { get; set; }

        /// <summary>
        /// 机具编码
        /// </summary>
        [XmlElement("machine_code")]
        public string MachineCode { get; set; }

        /// <summary>
        /// 机具型号
        /// </summary>
        [XmlElement("machine_model")]
        public string MachineModel { get; set; }

        /// <summary>
        /// 机具版本号
        /// </summary>
        [XmlElement("machine_ver")]
        public string MachineVer { get; set; }
    }
}
