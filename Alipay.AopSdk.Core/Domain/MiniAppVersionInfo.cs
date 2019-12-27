using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MiniAppVersionInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MiniAppVersionInfo : AopObject
    {
        /// <summary>
        /// Android客户端版本号信息
        /// </summary>
        [XmlElement("android_client_version_info")]
        public MiniAppClientVersionInfo AndroidClientVersionInfo { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 小程序构建日志地址
        /// </summary>
        [XmlElement("build_task_log")]
        public string BuildTaskLog { get; set; }

        /// <summary>
        /// 覆盖率包信息
        /// </summary>
        [XmlElement("coverage_package")]
        public MiniAppPackageInfo CoveragePackage { get; set; }

        /// <summary>
        /// 覆盖率完成度
        /// </summary>
        [XmlElement("coverage_rate")]
        public long CoverageRate { get; set; }

        /// <summary>
        /// 版本生成失败错误原因
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// iOS客户端版本号信息
        /// </summary>
        [XmlElement("ios_client_version_info")]
        public MiniAppClientVersionInfo IosClientVersionInfo { get; set; }

        /// <summary>
        /// 小程序预发包信息
        /// </summary>
        [XmlElement("preonline_package")]
        public MiniAppPackageInfo PreonlinePackage { get; set; }

        /// <summary>
        /// 安全扫描结果  True:安全扫描通过  False:安全扫描不通过  NAN:扫描中
        /// </summary>
        [XmlElement("security_scan_result")]
        public string SecurityScanResult { get; set; }

        /// <summary>
        /// 版本状态  PACKAGING:打包中  PACKAGE_FAILED:打包失败  PACKAGE_SUCCEED:打包完成  PACKAGE_DELETED:版本已删除  PRE_ONLINE:预发中  PRE_ONLINE_CONFIRM:预发完成  RELEASE:发布完成  OFFLINE:已下架
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
