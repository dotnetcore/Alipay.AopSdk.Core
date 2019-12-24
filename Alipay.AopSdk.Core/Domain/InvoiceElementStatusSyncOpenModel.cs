using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// InvoiceElementStatusSyncOpenModel Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceElementStatusSyncOpenModel : AopObject
    {
        /// <summary>
        /// 同步申请id，每次发起同步时生成，isv每次请求需要保证唯一
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 报销详情地址，提供用户通过发票管家查看报销进度的地址  如果报销企业入驻发票管家时需要isv传入报销详情地址，则必须提供
        /// </summary>
        [XmlElement("expense_detail_url")]
        public string ExpenseDetailUrl { get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        [XmlElement("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [XmlElement("invoice_no")]
        public string InvoiceNo { get; set; }
    }
}
