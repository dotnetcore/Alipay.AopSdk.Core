using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// ZolozIdentificationCustomerCertifyConsultResponse.
    /// </summary>
    public class ZolozIdentificationCustomerCertifyConsultResponse : AopResponse
    {
        /// <summary>
        /// 业务单据号，用于核对和排查
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 图片字节数组进行Base64编码后的字符串
        /// </summary>
        [XmlElement("img_str")]
        public string ImgStr { get; set; }
    }
}
