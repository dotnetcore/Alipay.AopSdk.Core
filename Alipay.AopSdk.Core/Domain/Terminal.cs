using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// Terminal Data Structure.
    /// </summary>
    [Serializable]
    public class Terminal : AopObject
    {
        /// <summary>
        /// 终端运行环境MAC地址列表，多个用“,”分割
        /// </summary>
        [XmlElement("mac")]
        public string Mac { get; set; }

        /// <summary>
        /// 操作系统类型
        /// </summary>
        [XmlElement("os")]
        public string Os { get; set; }

        /// <summary>
        /// 操作系统架构
        /// </summary>
        [XmlElement("os_arch")]
        public string OsArch { get; set; }

        /// <summary>
        /// 操作系统版本号
        /// </summary>
        [XmlElement("os_version")]
        public string OsVersion { get; set; }

        /// <summary>
        /// 终端类型
        /// </summary>
        [XmlElement("terminal_type")]
        public string TerminalType { get; set; }

        /// <summary>
        /// 终端版本号
        /// </summary>
        [XmlElement("terminal_version")]
        public string TerminalVersion { get; set; }
    }
}
