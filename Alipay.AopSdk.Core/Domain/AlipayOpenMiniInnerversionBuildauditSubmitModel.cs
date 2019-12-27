using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionBuildauditSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerversionBuildauditSubmitModel : AopObject
    {
        /// <summary>
        /// 小程序类目，可不传，不传取基础信息中的小程序类目
        /// </summary>
        [XmlElement("app_category_ids")]
        public string AppCategoryIds { get; set; }

        /// <summary>
        /// 小程序描述，可不传，不传取基础信息中的小程序描述
        /// </summary>
        [XmlElement("app_desc")]
        public string AppDesc { get; set; }

        /// <summary>
        /// 小程序在从未上架过版本之前，英文名称是可以修改的，该字段用于在提交审核时候修改小程序英文名称。注意：小程序一旦有过上架版本之后就不可以修改英文名称。
        /// </summary>
        [XmlElement("app_english_name")]
        public string AppEnglishName { get; set; }

        /// <summary>
        /// 小程序logo，可不传，不传取基础信息中的小程序logo，请调用专用的logo上传接口上传logo文件，并将返回的地址作为本字段传入
        /// </summary>
        [XmlElement("app_logo")]
        public string AppLogo { get; set; }

        /// <summary>
        /// 小程序在从未上架过版本之前，中文名称是可以修改的，该字段用于在提交审核时候修改小程序中文名称。注意：小程序一旦有过上架版本之后就不可以修改中文名称。
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 业务来源
        /// </summary>
        [XmlElement("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 小程序应用简介，一句话描述小程序功能，如果不填默认采用当前小程序应用简介，10~32个字符
        /// </summary>
        [XmlElement("app_slogan")]
        public string AppSlogan { get; set; }

        /// <summary>
        /// 小程序版本号
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 构建扩展参数
        /// </summary>
        [XmlElement("build_ext")]
        public string BuildExt { get; set; }

        /// <summary>
        /// 端信息
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 三方应用ID
        /// </summary>
        [XmlElement("isv_app_id")]
        public string IsvAppId { get; set; }

        /// <summary>
        /// 提审时，选择的所属类目需要校验营业执照，可不传，不传取基础信息中的小程序英文名称
        /// </summary>
        [XmlElement("license_info")]
        public AuditLicenseInfo LicenseInfo { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序开发者ID，可不传，不传取基础信息中的小程序开发者ID
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 服务区域类型,可不传，不传取基础信息中的小程序服务区域类型
        /// </summary>
        [XmlElement("region_type")]
        public string RegionType { get; set; }

        /// <summary>
        /// 版本截图，最少2张，最多5张，必传
        /// </summary>
        [XmlElement("screen_shot_list")]
        public string ScreenShotList { get; set; }

        /// <summary>
        /// 客服电话，可不传，不传取基础信息中的小程序客服电话
        /// </summary>
        [XmlElement("service_phone")]
        public string ServicePhone { get; set; }

        /// <summary>
        /// 小程序模板ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 模板的版本号，如果不填写，则默认用模板当前最新的在架版本
        /// </summary>
        [XmlElement("template_version")]
        public string TemplateVersion { get; set; }

        /// <summary>
        /// 小程序版本描述，30-500个字符，一个中文占两个字符，一个英文或者数字占一个字符
        /// </summary>
        [XmlElement("version_desc")]
        public string VersionDesc { get; set; }
    }
}
