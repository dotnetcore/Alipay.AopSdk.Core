using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayUserFinanceinfoShareResponse.
    /// </summary>
    public class AlipayUserFinanceinfoShareResponse : AopResponse
    {
        /// <summary>
        /// 查询出的信用卡列表，包含0到多张卡，每张卡对应一组信息，包含卡号（已脱敏）和开户行代码
        /// </summary>
        [XmlArray("credit_card_list")]
        [XmlArrayItem("alipay_user_credit_card")]
        public List<AlipayUserCreditCard> CreditCardList { get; set; }
    }
}
