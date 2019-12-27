using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// MybankFinanceYulibaoPriceQueryResponse.
    /// </summary>
    public class MybankFinanceYulibaoPriceQueryResponse : AopResponse
    {
        /// <summary>
        /// 余利宝行情信息列表
        /// </summary>
        [XmlArray("ylb_price_detail_infos")]
        [XmlArrayItem("y_l_b_price_detail_info")]
        public List<YLBPriceDetailInfo> YlbPriceDetailInfos { get; set; }
    }
}
