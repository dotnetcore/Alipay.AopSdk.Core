using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiServindustryExerciseNoticeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiServindustryExerciseNoticeCreateModel : AopObject
    {
        /// <summary>
        /// 外部通知ID
        /// </summary>
        [XmlElement("external_notice_id")]
        public string ExternalNoticeId { get; set; }

        /// <summary>
        /// 健身ID
        /// </summary>
        [XmlElement("fitness_id")]
        public string FitnessId { get; set; }

        /// <summary>
        /// 有效期结束时间
        /// </summary>
        [XmlElement("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 有效期开始时间
        /// </summary>
        [XmlElement("gmt_start")]
        public string GmtStart { get; set; }

        /// <summary>
        /// 跳转链接
        /// </summary>
        [XmlElement("jump_url")]
        public string JumpUrl { get; set; }

        /// <summary>
        /// 跳转链接类型
        /// </summary>
        [XmlElement("jump_url_type")]
        public string JumpUrlType { get; set; }

        /// <summary>
        /// 外部请求ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 消息子类型
        /// </summary>
        [XmlElement("sub_type")]
        public string SubType { get; set; }

        /// <summary>
        /// 通知模板动态参数
        /// </summary>
        [XmlElement("template_args")]
        public NoticeTemplateArgs TemplateArgs { get; set; }

        /// <summary>
        /// 推送标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 消息类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
