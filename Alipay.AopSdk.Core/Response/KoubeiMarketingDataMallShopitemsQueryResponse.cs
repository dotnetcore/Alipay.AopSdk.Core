using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// KoubeiMarketingDataMallShopitemsQueryResponse.
    /// </summary>
    public class KoubeiMarketingDataMallShopitemsQueryResponse : AopResponse
    {
        /// <summary>
        /// 店铺信息
        /// </summary>
        [XmlArray("shop_list")]
        [XmlArrayItem("t_b_mini_shop_bo")]
        public List<TBMiniShopBo> ShopList { get; set; }
    }
}
