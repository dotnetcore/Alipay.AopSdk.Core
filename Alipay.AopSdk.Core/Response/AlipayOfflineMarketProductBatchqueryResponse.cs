using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayOfflineMarketProductBatchqueryResponse.
    /// </summary>
    public class AlipayOfflineMarketProductBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("current_pageno")]
        public long CurrentPageno { get; set; }

        /// <summary>
        /// 商品列表ID，逗号分隔
        /// </summary>
        [XmlArray("item_ids")]
        [XmlArrayItem("string")]
        public List<string> ItemIds { get; set; }

        /// <summary>
        /// 总页码数
        /// </summary>
        [XmlElement("total_pageno")]
        public long TotalPageno { get; set; }
    }
}
