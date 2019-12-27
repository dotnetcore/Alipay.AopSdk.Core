using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// Hit Data Structure.
    /// </summary>
    [Serializable]
    public class Hit : AopObject
    {
        /// <summary>
        /// action跳转参数信息
        /// </summary>
        [XmlElement("action_param")]
        public string ActionParam { get; set; }

        /// <summary>
        /// 内容类型:  alipay:小程序  link:h5页面
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 业务id
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 命中的结果的描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 扩展信息,json字符串
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 显示的图标
        /// </summary>
        [XmlElement("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 命中的结果显示名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 搜索结果的来源方
        /// </summary>
        [XmlElement("provider")]
        public string Provider { get; set; }
    }
}
