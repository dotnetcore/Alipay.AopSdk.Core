using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AntMerchantExpandItemOpenBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandItemOpenBatchqueryModel : AopObject
    {
        /// <summary>
        /// 商品ID列表
        /// </summary>
        [XmlArray("item_id_list")]
        [XmlArrayItem("string")]
        public List<string> ItemIdList { get; set; }
    }
}
