using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiServindustryPortfolioOpusDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiServindustryPortfolioOpusDeleteModel : AopObject
    {
        /// <summary>
        /// 作品ID列表
        /// </summary>
        [XmlArray("opus_ids")]
        [XmlArrayItem("string")]
        public List<string> OpusIds { get; set; }

        /// <summary>
        /// 操作人信息
        /// </summary>
        [XmlElement("portfolio_operator_info")]
        public PortfolioOperatorInfo PortfolioOperatorInfo { get; set; }
    }
}
