using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiCateringQueueShopqueueinfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringQueueShopqueueinfoSyncModel : AopObject
    {
        /// <summary>
        /// 美味门店ID
        /// </summary>
        [XmlElement("out_shop_id")]
        public string OutShopId { get; set; }

        /// <summary>
        /// 队列信息
        /// </summary>
        [XmlArray("queue_list")]
        [XmlArrayItem("shop_queue")]
        public List<ShopQueue> QueueList { get; set; }

        /// <summary>
        /// 口碑门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 时间戳，用作数据的版本号，取系统当前时间即可
        /// </summary>
        [XmlElement("sync_timestamp")]
        public string SyncTimestamp { get; set; }
    }
}
