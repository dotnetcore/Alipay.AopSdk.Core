using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AntMerchantExpandItemOpenQueryResponse.
    /// </summary>
    public class AntMerchantExpandItemOpenQueryResponse : AopResponse
    {
        /// <summary>
        /// 商品列表
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("cm_item_info")]
        public List<CmItemInfo> ItemList { get; set; }
    }
}
