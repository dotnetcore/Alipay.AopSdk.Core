using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayDataBillBailQueryResponse.
    /// </summary>
    public class AlipayDataBillBailQueryResponse : AopResponse
    {
        /// <summary>
        /// 保证金明细列表，最多返回5000条
        /// </summary>
        [XmlArray("detail_list")]
        [XmlArrayItem("bail_detail_result")]
        public List<BailDetailResult> DetailList { get; set; }
    }
}
