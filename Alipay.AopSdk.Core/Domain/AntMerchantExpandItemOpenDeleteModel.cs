using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AntMerchantExpandItemOpenDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandItemOpenDeleteModel : AopObject
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }
    }
}
