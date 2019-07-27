using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// ZolozIdentificationCustomerCertifyzhubInitializeResponse.
    /// </summary>
    public class ZolozIdentificationCustomerCertifyzhubInitializeResponse : AopResponse
    {
        /// <summary>
        /// 业务单据号，用于核对和排查
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 人脸服务端返回码
        /// </summary>
        [XmlElement("zim_code")]
        public string ZimCode { get; set; }

        /// <summary>
        /// 唯一标识一次人脸服务的id
        /// </summary>
        [XmlElement("zim_id")]
        public string ZimId { get; set; }

        /// <summary>
        /// 人脸服务端返回信息
        /// </summary>
        [XmlElement("zim_msg")]
        public string ZimMsg { get; set; }
    }
}
