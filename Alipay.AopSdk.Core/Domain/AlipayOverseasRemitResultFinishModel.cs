using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOverseasRemitResultFinishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasRemitResultFinishModel : AopObject
    {
        /// <summary>
        /// 汇款结果
        /// </summary>
        [XmlElement("biz_result_code")]
        public string BizResultCode { get; set; }

        /// <summary>
        /// 汇款结果描述
        /// </summary>
        [XmlElement("biz_result_msg")]
        public string BizResultMsg { get; set; }

        /// <summary>
        /// 失败
        /// </summary>
        [XmlElement("biz_result_status")]
        public string BizResultStatus { get; set; }

        /// <summary>
        /// 完成时间
        /// </summary>
        [XmlElement("complete_time")]
        public string CompleteTime { get; set; }

        /// <summary>
        /// 发端的单据号
        /// </summary>
        [XmlElement("external_biz_no")]
        public string ExternalBizNo { get; set; }

        /// <summary>
        /// 接收端的mid
        /// </summary>
        [XmlElement("receiver_mid")]
        public string ReceiverMid { get; set; }

        /// <summary>
        /// 发端的mid
        /// </summary>
        [XmlElement("sender_mid")]
        public string SenderMid { get; set; }
    }
}
