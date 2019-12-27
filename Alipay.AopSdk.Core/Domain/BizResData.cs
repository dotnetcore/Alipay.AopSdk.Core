using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// BizResData Data Structure.
    /// </summary>
    [Serializable]
    public class BizResData : AopObject
    {
        /// <summary>
        /// 支用金额
        /// </summary>
        [XmlElement("biz_amount")]
        public long BizAmount { get; set; }

        /// <summary>
        /// 支用日期
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 业务借据号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 业务消费者唯一标志
        /// </summary>
        [XmlElement("biz_user_id")]
        public string BizUserId { get; set; }
    }
}
