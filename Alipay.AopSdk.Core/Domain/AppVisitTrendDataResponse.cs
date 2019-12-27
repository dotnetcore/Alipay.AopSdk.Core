using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AppVisitTrendDataResponse Data Structure.
    /// </summary>
    [Serializable]
    public class AppVisitTrendDataResponse : AopObject
    {
        /// <summary>
        /// 小程序的访问次数
        /// </summary>
        [XmlElement("app_pv")]
        public long AppPv { get; set; }

        /// <summary>
        /// 小程序访问人数
        /// </summary>
        [XmlElement("app_uv")]
        public long AppUv { get; set; }

        /// <summary>
        /// 数据采集时间 yyyy-MM-dd hh:mm:ss
        /// </summary>
        [XmlElement("report_time")]
        public string ReportTime { get; set; }
    }
}
