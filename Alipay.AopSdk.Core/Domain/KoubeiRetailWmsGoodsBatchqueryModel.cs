using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiRetailWmsGoodsBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsGoodsBatchqueryModel : AopObject
    {
        /// <summary>
        /// 货品编码，限制批量查询100个
        /// </summary>
        [XmlArray("goods_codes")]
        [XmlArrayItem("string")]
        public List<string> GoodsCodes { get; set; }
    }
}
