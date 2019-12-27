using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AntMerchantExpandItemStatusModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandItemStatusModifyModel : AopObject
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品状态：EFFECT、INVALID
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
