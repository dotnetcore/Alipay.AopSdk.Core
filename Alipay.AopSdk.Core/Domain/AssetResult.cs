using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AssetResult Data Structure.
    /// </summary>
    [Serializable]
    public class AssetResult : AopObject
    {
        /// <summary>
        /// 订单明细ID
        /// </summary>
        [XmlElement("assign_item_id")]
        public string AssignItemId { get; set; }

        /// <summary>
        /// 批次号，分批反馈时用
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("error_desc")]
        public string ErrorDesc { get; set; }

        /// <summary>
        /// openapi 请求id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// AssetSubFeedbackInfo 列表
        /// </summary>
        [XmlArray("sub_feedback_infos")]
        [XmlArrayItem("asset_sub_feedback_info")]
        public List<AssetSubFeedbackInfo> SubFeedbackInfos { get; set; }

        /// <summary>
        /// 是否处理成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
