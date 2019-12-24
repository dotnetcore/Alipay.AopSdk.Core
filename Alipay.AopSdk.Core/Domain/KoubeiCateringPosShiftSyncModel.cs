using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiCateringPosShiftSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosShiftSyncModel : AopObject
    {
        /// <summary>
        /// 班次信息
        /// </summary>
        [XmlArray("schedules")]
        [XmlArrayItem("shop_pos_schedule")]
        public List<ShopPosSchedule> Schedules { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
