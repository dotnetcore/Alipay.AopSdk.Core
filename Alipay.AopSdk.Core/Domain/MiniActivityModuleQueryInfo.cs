using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MiniActivityModuleQueryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MiniActivityModuleQueryInfo : AopObject
    {
        /// <summary>
        /// 行动点文案
        /// </summary>
        [XmlElement("action_text")]
        public string ActionText { get; set; }

        /// <summary>
        /// 记录唯一标识
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 图片链接
        /// </summary>
        [XmlElement("image")]
        public string Image { get; set; }

        /// <summary>
        /// logo
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序页面
        /// </summary>
        [XmlElement("page")]
        public string Page { get; set; }

        /// <summary>
        /// 副标题
        /// </summary>
        [XmlElement("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 跳转链接
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
