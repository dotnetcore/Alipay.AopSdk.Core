using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusOdGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataAiserviceCloudbusOdGetModel : AopObject
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
        /// 工作日和非工作日 枚举{WORKDAY,WEEKEND,ALL}
        /// </summary>
        [XmlElement("date_type")]
        public string DateType { get; set; }

        /// <summary>
        /// 结束时间精确到月。例如201901
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 起始区域 geohash list 。 区域必须连续，否则对结果有影响
        /// </summary>
        [XmlArray("origin_geo_hashs")]
        [XmlArrayItem("string")]
        public List<string> OriginGeoHashs { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 开始时间 精确到月 例如：201904
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
