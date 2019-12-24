using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOverseasTravelFliggyPoiCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTravelFliggyPoiCreateModel : AopObject
    {
        /// <summary>
        /// 同步数据版本
        /// </summary>
        [XmlElement("data_version")]
        public string DataVersion { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        [XmlElement("global_shop_id")]
        public string GlobalShopId { get; set; }

        /// <summary>
        /// 飞猪POI ID
        /// </summary>
        [XmlElement("poi_data")]
        public FliggyPoiInfo PoiData { get; set; }

        /// <summary>
        /// 外部请求ID,做幂等
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 支付宝端子任务类型，需回传
        /// </summary>
        [XmlElement("task_subtype")]
        public string TaskSubtype { get; set; }
    }
}
