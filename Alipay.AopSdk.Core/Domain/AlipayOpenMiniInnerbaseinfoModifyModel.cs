using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerbaseinfoModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerbaseinfoModifyModel : AopObject
    {
        /// <summary>
        /// 类目列表
        /// </summary>
        [XmlElement("app_category_ids")]
        public string AppCategoryIds { get; set; }

        /// <summary>
        /// 小程序应用描述，20-200个字
        /// </summary>
        [XmlElement("app_desc")]
        public string AppDesc { get; set; }

        /// <summary>
        /// 小程序应用英文名称
        /// </summary>
        [XmlElement("app_english_name")]
        public string AppEnglishName { get; set; }

        /// <summary>
        /// 手淘开放平台鉴权key，支付宝不需要
        /// </summary>
        [XmlElement("app_key")]
        public string AppKey { get; set; }

        /// <summary>
        /// 小程序logo图标，建议上传像素为180*180
        /// </summary>
        [XmlElement("app_logo")]
        public string AppLogo { get; set; }

        /// <summary>
        /// 小程序应用名称
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 小程序应用简介，一句话描述小程序功能
        /// </summary>
        [XmlElement("app_slogan")]
        public string AppSlogan { get; set; }

        /// <summary>
        /// 租户code，alipay 或是 taobao
        /// </summary>
        [XmlElement("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 小程序Id
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序客服邮箱
        /// </summary>
        [XmlElement("service_email")]
        public string ServiceEmail { get; set; }

        /// <summary>
        /// 小程序客服电话
        /// </summary>
        [XmlElement("service_phone")]
        public string ServicePhone { get; set; }
    }
}
