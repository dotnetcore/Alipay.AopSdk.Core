using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MybankCreditCreditriskWidgetQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditCreditriskWidgetQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝userid
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }
    }
}
