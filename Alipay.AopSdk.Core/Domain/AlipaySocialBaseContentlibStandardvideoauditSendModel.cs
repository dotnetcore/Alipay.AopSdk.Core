using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipaySocialBaseContentlibStandardvideoauditSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseContentlibStandardvideoauditSendModel : AopObject
    {
        /// <summary>
        /// publish(审核通过),  depublish(审核不通过)
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 扩展字段，传递非标准参数信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 驳回原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 操作日期
        /// </summary>
        [XmlElement("source_publish_date")]
        public string SourcePublishDate { get; set; }

        /// <summary>
        /// 视频Id
        /// </summary>
        [XmlElement("video_id")]
        public string VideoId { get; set; }

        /// <summary>
        /// 视频时长
        /// </summary>
        [XmlElement("video_length")]
        public string VideoLength { get; set; }

        /// <summary>
        /// 视频来源
        /// </summary>
        [XmlElement("video_publish_type")]
        public string VideoPublishType { get; set; }

        /// <summary>
        /// 视频的大小
        /// </summary>
        [XmlElement("video_size")]
        public string VideoSize { get; set; }

        /// <summary>
        /// 视频的标签，以,隔开
        /// </summary>
        [XmlElement("video_tags")]
        public string VideoTags { get; set; }

        /// <summary>
        /// video的url
        /// </summary>
        [XmlElement("video_url")]
        public string VideoUrl { get; set; }
    }
}
