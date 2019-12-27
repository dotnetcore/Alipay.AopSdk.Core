using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayFundTransGroupfundsPayauthConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundTransGroupfundsPayauthConsultModel : AopObject
    {
        /// <summary>
        /// 当前发起资金操作用户支付宝账户ID
        /// </summary>
        [XmlElement("current_user_id")]
        public string CurrentUserId { get; set; }

        /// <summary>
        /// 扩展请求参数，业务扩展时使用
        /// </summary>
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 资金操作类型，"collect": 收款，"payment": 付款
        /// </summary>
        [XmlElement("fund_type")]
        public string FundType { get; set; }

        /// <summary>
        /// 业务来源,对于聚会小程序统一透传"openParty"
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
