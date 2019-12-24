using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiServindustryReservationIsvorderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiServindustryReservationIsvorderSyncModel : AopObject
    {
        /// <summary>
        /// 用户到店时间
        /// </summary>
        [XmlElement("arrive_time")]
        public string ArriveTime { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 预订订单订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户在口碑开店后的门店号
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
