using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// SceneProdDeputyPaymentBillQuery Data Structure.
    /// </summary>
    [Serializable]
    public class SceneProdDeputyPaymentBillQuery : AopObject
    {
        /// <summary>
        /// 代客还款的网商银行结算户信息
        /// </summary>
        [XmlElement("deputy_account")]
        public string DeputyAccount { get; set; }

        /// <summary>
        /// 代客还款状态，VALID 代客还款， INVALID 取消代客还款，USING代客还款中，USED已代客还款
        /// </summary>
        [XmlElement("deputy_status")]
        public string DeputyStatus { get; set; }

        /// <summary>
        /// 期数
        /// </summary>
        [XmlElement("term")]
        public string Term { get; set; }
    }
}
