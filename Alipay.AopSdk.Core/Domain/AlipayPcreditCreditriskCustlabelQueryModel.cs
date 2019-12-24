using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayPcreditCreditriskCustlabelQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditCreditriskCustlabelQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝2088id
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }
    }
}
