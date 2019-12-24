using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiRetailWmsProducerBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsProducerBatchqueryModel : AopObject
    {
        /// <summary>
        /// 最多查询100个
        /// </summary>
        [XmlArray("producer_ids")]
        [XmlArrayItem("string")]
        public List<string> ProducerIds { get; set; }
    }
}
