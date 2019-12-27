using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayTradeRoyaltyRelationBatchqueryResponse.
    /// </summary>
    public class AlipayTradeRoyaltyRelationBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页数
        /// </summary>
        [XmlElement("current_page_num")]
        public long CurrentPageNum { get; set; }

        /// <summary>
        /// 当前页面大小
        /// </summary>
        [XmlElement("current_page_size")]
        public long CurrentPageSize { get; set; }

        /// <summary>
        /// 分账收款方列表
        /// </summary>
        [XmlArray("receiver_list")]
        [XmlArrayItem("royalty_entity")]
        public List<RoyaltyEntity> ReceiverList { get; set; }

        /// <summary>
        /// 业务结果码。SUCCESS：分账关系查询成功；FAIL：分账关系查询失败。
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_page_num")]
        public long TotalPageNum { get; set; }

        /// <summary>
        /// 分账关系记录总数
        /// </summary>
        [XmlElement("total_record_num")]
        public long TotalRecordNum { get; set; }
    }
}
