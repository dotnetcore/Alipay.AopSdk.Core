using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MybankPaymentTradeAccountSubvirtualcardCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankPaymentTradeAccountSubvirtualcardCreateModel : AopObject
    {
        /// <summary>
        /// 买家标识
        /// </summary>
        [XmlElement("member_id")]
        public string MemberId { get; set; }

        /// <summary>
        /// 卖家主卡户名
        /// </summary>
        [XmlElement("prim_card_name")]
        public string PrimCardName { get; set; }

        /// <summary>
        /// 卖家主卡号
        /// </summary>
        [XmlElement("prim_card_no")]
        public string PrimCardNo { get; set; }
    }
}
