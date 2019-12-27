using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AntMerchantExpandTradeorderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandTradeorderQueryModel : AopObject
    {
        /// <summary>
        /// 查询结果中是否需要包含指定订单下商品订单，默认false，即不包含指定订单下的商品订单
        /// </summary>
        [XmlElement("contain_item_order")]
        public bool ContainItemOrder { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
