using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayDataAiserviceSmartpriceMerchanteffectQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceSmartpriceMerchanteffectQueryResponse : AopResponse
    {
        /// <summary>
        /// 商家效果展示列表返回值
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("merchant_effect_query_result")]
        public List<MerchantEffectQueryResult> Result { get; set; }

        /// <summary>
        /// 最小定价单元,返回为""代表统计了该商户下所有定价单元指标之和
        /// </summary>
        [XmlElement("unit_id")]
        public string UnitId { get; set; }
    }
}
