using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiServindustryReservationResourcestatusSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiServindustryReservationResourcestatusSyncModel : AopObject
    {
        /// <summary>
        /// 消息变更类型
        /// </summary>
        [XmlArray("biz_type")]
        [XmlArrayItem("string")]
        public List<string> BizType { get; set; }

        /// <summary>
        /// 周期库存时间，当周期库存变更时必填
        /// </summary>
        [XmlElement("cycle_property_time")]
        public IsvCyclePropertyTimeModel CyclePropertyTime { get; set; }

        /// <summary>
        /// 资源状态变化的日期
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_time")]
        public ReservationTimeUnit EndTime { get; set; }

        /// <summary>
        /// 预订所属的行业
        /// </summary>
        [XmlElement("industry")]
        public string Industry { get; set; }

        /// <summary>
        /// 外部业务id，如ISV KTV包厢id
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 口碑预订资源id
        /// </summary>
        [XmlElement("resource_id")]
        public string ResourceId { get; set; }

        /// <summary>
        /// 口碑店铺id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("start_time")]
        public ReservationTimeUnit StartTime { get; set; }
    }
}
