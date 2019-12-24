using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// KoubeiMarketingDataNearmallQueryResponse.
    /// </summary>
    public class KoubeiMarketingDataNearmallQueryResponse : AopResponse
    {
        /// <summary>
        /// 商圈信息
        /// </summary>
        [XmlArray("near_mall_bos")]
        [XmlArrayItem("near_mall_bo")]
        public List<NearMallBo> NearMallBos { get; set; }
    }
}
