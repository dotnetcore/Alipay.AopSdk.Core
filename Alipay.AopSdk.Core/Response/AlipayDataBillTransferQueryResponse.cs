using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayDataBillTransferQueryResponse.
    /// </summary>
    public class AlipayDataBillTransferQueryResponse : AopResponse
    {
        /// <summary>
        /// 充值、提现、转账明细记录
        /// </summary>
        [XmlElement("detail_list")]
        public TransferDetailResult DetailList { get; set; }

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
        /// 充值、提现、转账明细总数。返回满足查询条件的明细的数量
        /// </summary>
        [XmlElement("total_size")]
        public string TotalSize { get; set; }
    }
}
