using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayAccountExrateRatequeryResponse.
    /// </summary>
    public class AlipayAccountExrateRatequeryResponse : AopResponse
    {
        /// <summary>
        /// 查询到的汇率对象列表，如果没有查询到则返回空列表
        /// </summary>
        [XmlArray("rate_query_response_list")]
        [XmlArrayItem("ex_ref_rate_info_v_o")]
        public List<ExRefRateInfoVO> RateQueryResponseList { get; set; }
    }
}
