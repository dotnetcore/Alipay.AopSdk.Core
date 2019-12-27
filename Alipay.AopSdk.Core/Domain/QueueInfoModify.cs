using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// QueueInfoModify Data Structure.
    /// </summary>
    [Serializable]
    public class QueueInfoModify : AopObject
    {
        /// <summary>
        /// 队列ID
        /// </summary>
        [XmlElement("queue_id")]
        public string QueueId { get; set; }

        /// <summary>
        /// 订单排队号
        /// </summary>
        [XmlElement("queue_no")]
        public string QueueNo { get; set; }

        /// <summary>
        /// 当前等待人数
        /// </summary>
        [XmlElement("queue_wait")]
        public long QueueWait { get; set; }

        /// <summary>
        /// 预计等待时间（单位：分钟）
        /// </summary>
        [XmlElement("queue_wait_time")]
        public long QueueWaitTime { get; set; }
    }
}
