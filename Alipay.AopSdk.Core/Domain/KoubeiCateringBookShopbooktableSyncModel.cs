using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiCateringBookShopbooktableSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringBookShopbooktableSyncModel : AopObject
    {
        /// <summary>
        /// 可选时间段
        /// </summary>
        [XmlArray("book_time")]
        [XmlArrayItem("book_time")]
        public List<BookTime> BookTime { get; set; }

        /// <summary>
        /// 美味门店ID
        /// </summary>
        [XmlElement("out_shop_id")]
        public string OutShopId { get; set; }

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
