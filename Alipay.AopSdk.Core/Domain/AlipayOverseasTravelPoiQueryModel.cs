using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOverseasTravelPoiQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTravelPoiQueryModel : AopObject
    {
        /// <summary>
        /// 店铺id
        /// </summary>
        [XmlElement("global_shop_id")]
        public string GlobalShopId { get; set; }

        /// <summary>
        /// 飞猪poiId
        /// </summary>
        [XmlElement("poi_id")]
        public string PoiId { get; set; }

        /// <summary>
        /// 回传同步POI信息扩展字段中的poi_task_sub_type
        /// </summary>
        [XmlElement("poi_task_sub_type")]
        public string PoiTaskSubType { get; set; }
    }
}
