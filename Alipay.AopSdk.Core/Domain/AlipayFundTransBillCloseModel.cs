using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayFundTransBillCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundTransBillCloseModel : AopObject
    {
        /// <summary>
        /// 支付宝转账单据号
        /// </summary>
        [XmlElement("transfer_no")]
        public string TransferNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
