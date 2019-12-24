using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayEcoEduKtZftschoolQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoEduKtZftschoolQueryModel : AopObject
    {
        /// <summary>
        /// 进件单号id，进件接口返回
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// ISV的支付宝唯一标识PID
        /// </summary>
        [XmlElement("partner_pid")]
        public string PartnerPid { get; set; }
    }
}
