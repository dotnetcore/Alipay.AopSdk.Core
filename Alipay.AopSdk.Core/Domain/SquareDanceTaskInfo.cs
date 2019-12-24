using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// SquareDanceTaskInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SquareDanceTaskInfo : AopObject
    {
        /// <summary>
        /// 应用id，固定值，用于识别相关调用方的应用来源
        /// </summary>
        [XmlElement("application_id")]
        public string ApplicationId { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 跳转地址
        /// </summary>
        [XmlElement("button_action_url")]
        public string ButtonActionUrl { get; set; }

        /// <summary>
        /// 相关任务的按钮文案，列表中展示
        /// </summary>
        [XmlElement("button_text")]
        public string ButtonText { get; set; }

        /// <summary>
        /// 额外参数，json串
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 任务流水id，唯一值，用于双方幂等控制
        /// </summary>
        [XmlElement("flow_id")]
        public string FlowId { get; set; }

        /// <summary>
        /// 域内可以访问的图片地址，在任务列表中进行展示
        /// </summary>
        [XmlElement("img_url")]
        public string ImgUrl { get; set; }

        /// <summary>
        /// 任务状态，包括"TO_APPLY"："待申领","PROCESSING"： "进行中","COMPLETE"："已完成"
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 对于任务进行的描述说明
        /// </summary>
        [XmlElement("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 任务id，biz_type+创建日期+主键组成
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 任务标题，在任务列表页直接展示
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 完成任务用户可以获得的票数（任务奖励）
        /// </summary>
        [XmlElement("votes")]
        public long Votes { get; set; }
    }
}
