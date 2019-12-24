using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayIserviceCognitiveClassificationFeedbackSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCognitiveClassificationFeedbackSyncModel : AopObject
    {
        /// <summary>
        /// 反馈结果：同意，修正，忽略
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 业务编码
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 图片url，或者文本
        /// </summary>
        [XmlElement("cognition_content")]
        public string CognitionContent { get; set; }

        /// <summary>
        /// 数据类型
        /// </summary>
        [XmlElement("cognition_type")]
        public string CognitionType { get; set; }

        /// <summary>
        /// 用户反馈的垃圾类别
        /// </summary>
        [XmlElement("feedback_category")]
        public string FeedbackCategory { get; set; }

        /// <summary>
        /// 用户反馈的正确的垃圾名称
        /// </summary>
        [XmlElement("feedback_rubbish")]
        public string FeedbackRubbish { get; set; }

        /// <summary>
        /// 预测的垃圾类别
        /// </summary>
        [XmlElement("predict_category")]
        public string PredictCategory { get; set; }

        /// <summary>
        /// 垃圾名称
        /// </summary>
        [XmlElement("predict_rubbish")]
        public string PredictRubbish { get; set; }

        /// <summary>
        /// traceid
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
