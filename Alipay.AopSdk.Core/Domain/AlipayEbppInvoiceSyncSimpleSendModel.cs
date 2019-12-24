using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceSyncSimpleSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceSyncSimpleSendModel : AopObject
    {
        /// <summary>
        /// 回传的发票信息
        /// </summary>
        [XmlElement("invoice_info")]
        public InvoicePDFSynModel InvoiceInfo { get; set; }

        /// <summary>
        /// 开票商户品牌简称，与商户入驻时的品牌简称保持一致。
        /// </summary>
        [XmlElement("m_short_name")]
        public string MShortName { get; set; }

        /// <summary>
        /// 开票商户门店简称，与商户入驻时的门店简称保持一致。
        /// </summary>
        [XmlElement("sub_m_short_name")]
        public string SubMShortName { get; set; }
    }
}
