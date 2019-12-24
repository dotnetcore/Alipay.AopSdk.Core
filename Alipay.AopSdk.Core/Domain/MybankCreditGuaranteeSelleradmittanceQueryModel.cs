using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MybankCreditGuaranteeSelleradmittanceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditGuaranteeSelleradmittanceQueryModel : AopObject
    {
        /// <summary>
        /// AE卖家sellerLoginID
        /// </summary>
        [XmlElement("seller_login_id")]
        public string SellerLoginId { get; set; }

        /// <summary>
        /// 会员站点：AE:速卖通，ALIPAY:支付宝，MYBANK:网商银行，TAOBAO：淘宝，B2B_CN：中文站，B2B_EN：国际站
        /// </summary>
        [XmlElement("site")]
        public string Site { get; set; }
    }
}
