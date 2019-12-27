using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// IndexDetail Data Structure.
    /// </summary>
    [Serializable]
    public class IndexDetail : AopObject
    {
        /// <summary>
        /// 区域编码
        /// </summary>
        [XmlElement("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 区域名称
        /// </summary>
        [XmlElement("area_name")]
        public string AreaName { get; set; }

        /// <summary>
        /// 当月市排名
        /// </summary>
        [XmlElement("city_ranking")]
        public string CityRanking { get; set; }

        /// <summary>
        /// 当月区排名
        /// </summary>
        [XmlElement("county_ranking")]
        public string CountyRanking { get; set; }

        /// <summary>
        /// 主键
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 指数值
        /// </summary>
        [XmlElement("index_val")]
        public string IndexVal { get; set; }

        /// <summary>
        /// 年月
        /// </summary>
        [XmlElement("period")]
        public string Period { get; set; }
    }
}
