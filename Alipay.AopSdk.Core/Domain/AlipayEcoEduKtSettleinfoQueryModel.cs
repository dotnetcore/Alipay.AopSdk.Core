using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayEcoEduKtSettleinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoEduKtSettleinfoQueryModel : AopObject
    {
        /// <summary>
        /// 结算日期：格式为yyyy-MM-dd
        /// </summary>
        [XmlElement("bill_date")]
        public string BillDate { get; set; }

        /// <summary>
        /// ISV的支付宝唯一标识PID
        /// </summary>
        [XmlElement("partner_pid")]
        public string PartnerPid { get; set; }

        /// <summary>
        /// 支付宝中小学教育缴费分配给学校的编码，学校在支付宝的标识
        /// </summary>
        [XmlElement("school_no")]
        public string SchoolNo { get; set; }

        /// <summary>
        /// 直付通二级商户id，商户进件审核通过后会有smid,查询结算信息必须有此信息
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }
    }
}
