using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ZhimaCreditPeIndustryOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPeIndustryOrderQueryModel : AopObject
    {
        /// <summary>
        /// 扩展信息字段，格式:json，注意，如果字符串对应的json对象包含中文字符，需要对包含中文的字段进行编码
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 商户的外部订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 签约产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 平台订单号
        /// </summary>
        [XmlElement("zm_order_id")]
        public string ZmOrderId { get; set; }
    }
}
