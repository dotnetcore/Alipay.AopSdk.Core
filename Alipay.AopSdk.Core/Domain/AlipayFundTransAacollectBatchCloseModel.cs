using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayFundTransAacollectBatchCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundTransAacollectBatchCloseModel : AopObject
    {
        /// <summary>
        /// 批次号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 创建批次返回 的token
        /// </summary>
        [XmlElement("batch_token")]
        public string BatchToken { get; set; }

        /// <summary>
        /// 当前支付宝用户id
        /// </summary>
        [XmlElement("current_user_id")]
        public string CurrentUserId { get; set; }
    }
}
