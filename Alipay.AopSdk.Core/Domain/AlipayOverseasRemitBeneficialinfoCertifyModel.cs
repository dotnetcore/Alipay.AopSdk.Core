using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOverseasRemitBeneficialinfoCertifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasRemitBeneficialinfoCertifyModel : AopObject
    {
        /// <summary>
        /// 中文名
        /// </summary>
        [XmlElement("chinese_full_name")]
        public string ChineseFullName { get; set; }

        /// <summary>
        /// 用户的名，拼音
        /// </summary>
        [XmlElement("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// 用户的姓，拼音
        /// </summary>
        [XmlElement("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// 登录ID
        /// </summary>
        [XmlElement("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 用户中间的名字
        /// </summary>
        [XmlElement("middle_name")]
        public string MiddleName { get; set; }

        /// <summary>
        /// 汇款金额
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 汇款金额的币种
        /// </summary>
        [XmlElement("order_currency")]
        public string OrderCurrency { get; set; }

        /// <summary>
        /// 接收端的mid
        /// </summary>
        [XmlElement("receiver_mid")]
        public string ReceiverMid { get; set; }

        /// <summary>
        /// 发端的mid
        /// </summary>
        [XmlElement("sender_mid")]
        public string SenderMid { get; set; }
    }
}
