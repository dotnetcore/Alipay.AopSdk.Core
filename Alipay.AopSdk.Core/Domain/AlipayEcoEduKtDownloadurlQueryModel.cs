using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayEcoEduKtDownloadurlQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoEduKtDownloadurlQueryModel : AopObject
    {
        /// <summary>
        /// 账单时间：日账单格式为yyyy-MM-dd
        /// </summary>
        [XmlElement("bill_date")]
        public string BillDate { get; set; }

        /// <summary>
        /// ISV的支付宝唯一标识PID
        /// </summary>
        [XmlElement("partner_pid")]
        public string PartnerPid { get; set; }
    }
}
