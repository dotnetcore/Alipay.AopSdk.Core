using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MiniAppVersionBaseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MiniAppVersionBaseInfo : AopObject
    {
        /// <summary>
        /// 开发者版本
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 01 自创建 02 模板构建
        /// </summary>
        [XmlElement("build_source")]
        public string BuildSource { get; set; }

        /// <summary>
        /// 端标识
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 版本描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 模板实例化小程序参数
        /// </summary>
        [XmlElement("ext_json")]
        public string ExtJson { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 灰度开始时间
        /// </summary>
        [XmlElement("gray_start_time")]
        public string GrayStartTime { get; set; }

        /// <summary>
        /// 租户
        /// </summary>
        [XmlElement("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 下架时间
        /// </summary>
        [XmlElement("offline_time")]
        public string OfflineTime { get; set; }

        /// <summary>
        /// 包地址
        /// </summary>
        [XmlElement("package_url")]
        public string PackageUrl { get; set; }

        /// <summary>
        /// 插件plugin包地址
        /// </summary>
        [XmlElement("plugin_url")]
        public string PluginUrl { get; set; }

        /// <summary>
        /// 回滚时间
        /// </summary>
        [XmlElement("rollback_time")]
        public string RollbackTime { get; set; }

        /// <summary>
        /// 上架时间
        /// </summary>
        [XmlElement("shelf_time")]
        public string ShelfTime { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 子状态
        /// </summary>
        [XmlElement("sub_status")]
        public string SubStatus { get; set; }

        /// <summary>
        /// 构建模板参数
        /// </summary>
        [XmlElement("template_extra")]
        public string TemplateExtra { get; set; }

        /// <summary>
        /// 模板应用ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 模板版本
        /// </summary>
        [XmlElement("template_version")]
        public string TemplateVersion { get; set; }
    }
}
