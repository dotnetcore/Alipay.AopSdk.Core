using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MybankPaymentTradeFinancingOrderCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankPaymentTradeFinancingOrderCloseModel : AopObject
    {
        /// <summary>
        /// 扩展字段，JSON格式 URLEncoder.encode(String,"UTF-8")
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 合作机构编码，阿里云填aliyun
        /// </summary>
        [XmlElement("ext_partner")]
        public string ExtPartner { get; set; }

        /// <summary>
        /// order_no
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 订单类型，FINANCING_PAY-预付融资
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 请求流水号
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 请求时间，格式yyyyMMddHHmmss
        /// </summary>
        [XmlElement("request_time")]
        public string RequestTime { get; set; }

        /// <summary>
        /// 填MYBKC1CN，表示网商
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
