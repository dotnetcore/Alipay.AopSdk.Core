using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ApplyBusinessCity Data Structure.
    /// </summary>
    [Serializable]
    public class ApplyBusinessCity : AopObject
    {
        /// <summary>
        /// 业务归属地区编码,精确到区县
        /// </summary>
        [XmlElement("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 投保地区用户选择的层级
        /// </summary>
        [XmlElement("city_level")]
        public string CityLevel { get; set; }
    }
}
