using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionTemplatebasedUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerversionTemplatebasedUploadModel : AopObject
    {
        /// <summary>
        /// 版本号
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 构建拓展参数
        /// </summary>
        [XmlElement("build_extra_info")]
        public string BuildExtraInfo { get; set; }

        /// <summary>
        /// 淘宝：com.taobao.app
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 租户编码
        /// </summary>
        [XmlElement("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 端标识
        /// </summary>
        [XmlElement("template_bundle_id")]
        public string TemplateBundleId { get; set; }

        /// <summary>
        /// 模板ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [XmlElement("template_version")]
        public string TemplateVersion { get; set; }

        /// <summary>
        /// 模板实例化后版本的状态，当前支持实例化后的版本为初始化状态（INIT），或直接上架（RELEASE），不传默认为INIT
        /// </summary>
        [XmlElement("version_status")]
        public string VersionStatus { get; set; }
    }
}
