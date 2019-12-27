using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiCateringBookShopinfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringBookShopinfoSyncModel : AopObject
    {
        /// <summary>
        /// 桌位保留时间（单位：分钟）
        /// </summary>
        [XmlElement("book_keep_time")]
        public long BookKeepTime { get; set; }

        /// <summary>
        /// 预订文案
        /// </summary>
        [XmlElement("book_text")]
        public string BookText { get; set; }

        /// <summary>
        /// 最长预订多少时间（单位：分钟）
        /// </summary>
        [XmlElement("max_book_time")]
        public long MaxBookTime { get; set; }

        /// <summary>
        /// 包厢最大人数
        /// </summary>
        [XmlElement("max_box_num")]
        public long MaxBoxNum { get; set; }

        /// <summary>
        /// 最小起订人数
        /// </summary>
        [XmlElement("min_book_num")]
        public long MinBookNum { get; set; }

        /// <summary>
        /// 最少提前预订时间（单位：分钟）
        /// </summary>
        [XmlElement("min_book_time")]
        public long MinBookTime { get; set; }

        /// <summary>
        /// 包厢最小人数
        /// </summary>
        [XmlElement("min_box_num")]
        public long MinBoxNum { get; set; }

        /// <summary>
        /// 美味门店ID
        /// </summary>
        [XmlElement("out_shop_id")]
        public string OutShopId { get; set; }

        /// <summary>
        /// 是否开启下单备注。如true表示开启，如false表示不开启。
        /// </summary>
        [XmlElement("remark_flag")]
        public bool RemarkFlag { get; set; }

        /// <summary>
        /// 口碑门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 门店状态。如BOOKABLE表示可预订，UNBOOKABLE表示不可预订。
        /// </summary>
        [XmlElement("shop_state")]
        public string ShopState { get; set; }

        /// <summary>
        /// 是否有包厢。如true表示有，如false表示没有。
        /// </summary>
        [XmlElement("support_box")]
        public bool SupportBox { get; set; }

        /// <summary>
        /// 是否支持秒订。如true表示支持，false表示不支持。
        /// </summary>
        [XmlElement("support_quick_book")]
        public bool SupportQuickBook { get; set; }

        /// <summary>
        /// 时间戳，用作数据的版本号，取系统当前时间即可
        /// </summary>
        [XmlElement("sync_timestamp")]
        public string SyncTimestamp { get; set; }
    }
}
