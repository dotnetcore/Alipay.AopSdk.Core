using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MallConsumeVoucher Data Structure.
    /// </summary>
    [Serializable]
    public class MallConsumeVoucher : AopObject
    {
        /// <summary>
        /// 券品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 消费送活动id
        /// </summary>
        [XmlElement("source_camp")]
        public string SourceCamp { get; set; }

        /// <summary>
        /// 券类型
        /// </summary>
        [XmlElement("voucher_type")]
        public string VoucherType { get; set; }

        /// <summary>
        /// 券面额或者折扣
        /// </summary>
        [XmlElement("worth_value")]
        public string WorthValue { get; set; }
    }
}
