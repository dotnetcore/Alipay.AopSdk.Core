using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// RatioDetail Data Structure.
    /// </summary>
    [Serializable]
    public class RatioDetail : AopObject
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
        /// 主键
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 年月
        /// </summary>
        [XmlElement("period")]
        public string Period { get; set; }

        /// <summary>
        /// 占比的标签名称
        /// </summary>
        [XmlElement("ratio_label")]
        public string RatioLabel { get; set; }

        /// <summary>
        /// 占比数值，为百分比的小数数值
        /// </summary>
        [XmlElement("ratio_val")]
        public string RatioVal { get; set; }
    }
}
