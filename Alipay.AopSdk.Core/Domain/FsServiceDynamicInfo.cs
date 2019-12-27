using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// FsServiceDynamicInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FsServiceDynamicInfo : AopObject
    {
        /// <summary>
        /// 内容键 subjectData：主体数据
        /// </summary>
        [XmlElement("content_key")]
        public string ContentKey { get; set; }

        /// <summary>
        /// 数据类型； YIELD_TYPE：收益率，SUM：累计次数，CHANGE：涨跌幅，PRICE：价格，GOLD_PRICE：黄金价格，PROBABILITY：概率
        /// </summary>
        [XmlElement("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// 内容值
        /// </summary>
        [XmlElement("content_value")]
        public string ContentValue { get; set; }

        /// <summary>
        /// 终止有效期（含）
        /// </summary>
        [XmlElement("end_valid_date")]
        public string EndValidDate { get; set; }

        /// <summary>
        /// 数据其实有效期（含）
        /// </summary>
        [XmlElement("start_valid_date")]
        public string StartValidDate { get; set; }
    }
}
