using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionUploadstatusQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerversionUploadstatusQueryModel : AopObject
    {
        /// <summary>
        /// 包管理ID，用于查询打包状态
        /// </summary>
        [XmlElement("build_package_id")]
        public string BuildPackageId { get; set; }

        /// <summary>
        /// 小程序版本
        /// </summary>
        [XmlElement("build_version")]
        public string BuildVersion { get; set; }

        /// <summary>
        /// 端信息
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [XmlElement("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
