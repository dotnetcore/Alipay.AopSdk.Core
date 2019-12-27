using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceInfoSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceInfoSendModel : AopObject
    {
        /// <summary>
        /// 发票信息列表
        /// </summary>
        [XmlArray("invoice_info_list")]
        [XmlArrayItem("invoice_send_open_model")]
        public List<InvoiceSendOpenModel> InvoiceInfoList { get; set; }

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
