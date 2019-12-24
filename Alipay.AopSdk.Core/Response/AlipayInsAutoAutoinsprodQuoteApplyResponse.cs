using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayInsAutoAutoinsprodQuoteApplyResponse.
    /// </summary>
    public class AlipayInsAutoAutoinsprodQuoteApplyResponse : AopResponse
    {
        /// <summary>
        /// 车险询价申请号
        /// </summary>
        [XmlElement("enquiry_biz_id")]
        public string EnquiryBizId { get; set; }

        /// <summary>
        /// 报价返回信息
        /// </summary>
        [XmlArray("quote_infos")]
        [XmlArrayItem("quote_info")]
        public List<QuoteInfo> QuoteInfos { get; set; }
    }
}
