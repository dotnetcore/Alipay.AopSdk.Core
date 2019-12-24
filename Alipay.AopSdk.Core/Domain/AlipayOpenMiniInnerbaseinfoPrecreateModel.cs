using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerbaseinfoPrecreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerbaseinfoPrecreateModel : AopObject
    {
        /// <summary>
        /// 小程序类目ID列表
        /// </summary>
        [XmlElement("app_category_ids")]
        public string AppCategoryIds { get; set; }

        /// <summary>
        /// 小程序应用描述
        /// </summary>
        [XmlElement("app_desc")]
        public string AppDesc { get; set; }

        /// <summary>
        /// 小程序英文名称
        /// </summary>
        [XmlElement("app_english_name")]
        public string AppEnglishName { get; set; }

        /// <summary>
        /// 小程序logo图片地址
        /// </summary>
        [XmlElement("app_logo")]
        public string AppLogo { get; set; }

        /// <summary>
        /// 小程序中文名
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 应用创建方，接入时请联系minicenter owner添加
        /// </summary>
        [XmlElement("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 应用简介
        /// </summary>
        [XmlElement("app_slogan")]
        public string AppSlogan { get; set; }

        /// <summary>
        /// 小程序应用类型  普通小程序: TINYAPP_NORMAL
        /// </summary>
        [XmlElement("app_sub_type")]
        public string AppSubType { get; set; }

        /// <summary>
        /// 小程序业务主体
        /// </summary>
        [XmlElement("owner_entity")]
        public string OwnerEntity { get; set; }

        /// <summary>
        /// 接入方所属域，接入前请联系系统owner提供  MAYI：蚂蚁域内应用  ALIBABA：阿里域内应用
        /// </summary>
        [XmlElement("partner_domain")]
        public string PartnerDomain { get; set; }

        /// <summary>
        /// 小程序主账户ID
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 小程序客服电话
        /// </summary>
        [XmlElement("service_phone")]
        public string ServicePhone { get; set; }
    }
}
