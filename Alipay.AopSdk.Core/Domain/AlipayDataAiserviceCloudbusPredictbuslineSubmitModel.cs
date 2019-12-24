using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusPredictbuslineSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataAiserviceCloudbusPredictbuslineSubmitModel : AopObject
    {
        /// <summary>
        /// 接口版本
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 公交线路版本号
        /// </summary>
        [XmlElement("route_version")]
        public string RouteVersion { get; set; }

        /// <summary>
        /// 客流预测公交线路列表
        /// </summary>
        [XmlArray("routes")]
        [XmlArrayItem("cloudbus_route")]
        public List<CloudbusRoute> Routes { get; set; }

        /// <summary>
        /// 客流预测任务描述
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
