using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiRetailWmsGoodssafetyinventoryBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsGoodssafetyinventoryBatchqueryModel : AopObject
    {
        /// <summary>
        /// 货品编码，限制最大查询数量1000
        /// </summary>
        [XmlArray("goods_codes")]
        [XmlArrayItem("string")]
        public List<string> GoodsCodes { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        [XmlElement("warehouse_code")]
        public string WarehouseCode { get; set; }
    }
}
