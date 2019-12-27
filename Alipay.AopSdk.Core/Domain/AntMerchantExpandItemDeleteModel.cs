using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AntMerchantExpandItemDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandItemDeleteModel : AopObject
    {
        /// <summary>
        /// 外部商品ID（item_id不为空则以item_id作为删除KEY,item_id为空则以external_item_id作为删除KEY,两者不能同时为空）
        /// </summary>
        [XmlElement("external_item_id")]
        public string ExternalItemId { get; set; }

        /// <summary>
        /// 商品ID（item_id不为空则以item_id作为删除KEY,item_id为空则以external_item_id作为删除KEY,两者不能同时为空）
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }
    }
}
