using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayEcoRenthouseBillOrderDownloadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoRenthouseBillOrderDownloadModel : AopObject
    {
        /// <summary>
        /// 查询日期
        /// </summary>
        [XmlElement("bill_date")]
        public string BillDate { get; set; }

        /// <summary>
        /// 商户编号
        /// </summary>
        [XmlElement("merchant_no")]
        public string MerchantNo { get; set; }
    }
}
