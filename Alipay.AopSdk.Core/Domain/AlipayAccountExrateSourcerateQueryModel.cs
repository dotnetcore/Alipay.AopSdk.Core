using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayAccountExrateSourcerateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAccountExrateSourcerateQueryModel : AopObject
    {
        /// <summary>
        /// 查询截止报价生成时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 报价生成日期。查询结果为大于该报价生成日期的源汇率记录
        /// </summary>
        [XmlElement("generate_date")]
        public string GenerateDate { get; set; }

        /// <summary>
        /// 报价是否异常。枚举值：Y、N，除此之外都为非法值
        /// </summary>
        [XmlElement("is_exception")]
        public string IsException { get; set; }

        /// <summary>
        /// 源汇率编码
        /// </summary>
        [XmlElement("rate_source_code")]
        public string RateSourceCode { get; set; }

        /// <summary>
        /// 查询记录行数。大于0的整数值，最大长度超长则异常
        /// </summary>
        [XmlElement("size")]
        public long Size { get; set; }

        /// <summary>
        /// 查询起始报价生成时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
