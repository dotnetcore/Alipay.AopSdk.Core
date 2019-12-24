using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ShopQueue Data Structure.
    /// </summary>
    [Serializable]
    public class ShopQueue : AopObject
    {
        /// <summary>
        /// 队列最大人数
        /// </summary>
        [XmlElement("max_queue_num")]
        public long MaxQueueNum { get; set; }

        /// <summary>
        /// 队列最小人数
        /// </summary>
        [XmlElement("min_queue_num")]
        public long MinQueueNum { get; set; }

        /// <summary>
        /// 队列描述
        /// </summary>
        [XmlElement("queue_desc")]
        public string QueueDesc { get; set; }

        /// <summary>
        /// 队列ID。作为队列唯一主键，调用方应保证此字段在同一门店内唯一。
        /// </summary>
        [XmlElement("queue_id")]
        public string QueueId { get; set; }

        /// <summary>
        /// 队列名字
        /// </summary>
        [XmlElement("queue_name")]
        public string QueueName { get; set; }

        /// <summary>
        /// 队列类型。  如NONVIP表示默认非VIP；VIP1表示VIP1队；VIP2表示VIP2队列
        /// </summary>
        [XmlElement("queue_option")]
        public string QueueOption { get; set; }

        /// <summary>
        /// 队列前缀
        /// </summary>
        [XmlElement("queue_prefix")]
        public string QueuePrefix { get; set; }
    }
}
