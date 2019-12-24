using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayDataBillAccountlogQueryResponse.
    /// </summary>
    public class AlipayDataBillAccountlogQueryResponse : AopResponse
    {
        /// <summary>
        /// 账务明细返回结果
        /// </summary>
        [XmlArray("detail_list")]
        [XmlArrayItem("account_log_item_result")]
        public List<AccountLogItemResult> DetailList { get; set; }

        /// <summary>
        /// 分页号，从1开始
        /// </summary>
        [XmlElement("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 分页大小1000-2000
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 账务明细总数。返回满足查询条件的明细的数量
        /// </summary>
        [XmlElement("total_size")]
        public string TotalSize { get; set; }
    }
}
