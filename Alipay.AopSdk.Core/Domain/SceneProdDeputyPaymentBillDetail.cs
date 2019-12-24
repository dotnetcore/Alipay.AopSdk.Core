using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// SceneProdDeputyPaymentBillDetail Data Structure.
    /// </summary>
    [Serializable]
    public class SceneProdDeputyPaymentBillDetail : AopObject
    {
        /// <summary>
        /// 代客还款的网商银行结算户信息
        /// </summary>
        [XmlElement("deputy_account")]
        public string DeputyAccount { get; set; }

        /// <summary>
        /// 代客还款操作类型，VALID 代客还款， INVALID 取消代客还款
        /// </summary>
        [XmlElement("deputy_type")]
        public string DeputyType { get; set; }

        /// <summary>
        /// 期数
        /// </summary>
        [XmlElement("term")]
        public string Term { get; set; }
    }
}
