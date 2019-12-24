using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceAuthSignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceAuthSignModel : AopObject
    {
        /// <summary>
        /// 发票授权类型，可选值：INVOICE_AUTO_SYNC（发票自动回传）
        /// </summary>
        [XmlElement("authorization_type")]
        public string AuthorizationType { get; set; }

        /// <summary>
        /// 开票商户品牌简称，与商户入驻时的品牌简称保持一致。
        /// </summary>
        [XmlElement("m_short_name")]
        public string MShortName { get; set; }

        /// <summary>
        /// 支付宝用户userId
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
