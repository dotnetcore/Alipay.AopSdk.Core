using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceListExpenseSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceListExpenseSyncModel : AopObject
    {
        /// <summary>
        /// 报销进度变更时间
        /// </summary>
        [XmlElement("business_time")]
        public string BusinessTime { get; set; }

        /// <summary>
        /// 商户报销单据号
        /// </summary>
        [XmlElement("expense_order_no")]
        public string ExpenseOrderNo { get; set; }

        /// <summary>
        /// 报销企业税号
        /// </summary>
        [XmlElement("expense_tax_no")]
        public string ExpenseTaxNo { get; set; }

        /// <summary>
        /// 需要同步报销状态的发票列表
        /// </summary>
        [XmlArray("invoice_element_list")]
        [XmlArrayItem("invoice_element_status_sync_open_model")]
        public List<InvoiceElementStatusSyncOpenModel> InvoiceElementList { get; set; }

        /// <summary>
        /// 报销审批备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// EXPENSE_APPLY:报销申请提交;EXPENSE_APPROVAL_PASS:报销申请审核通过;EXPENSE_FINISHED:报销申请完成;EXPENSE_CANCEL:报销申请撤回
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 用户uid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
