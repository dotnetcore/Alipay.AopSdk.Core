using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// ZolozAuthenticationCustomerFacemanageDeleteResponse.
    /// </summary>
    public class ZolozAuthenticationCustomerFacemanageDeleteResponse : AopResponse
    {
        /// <summary>
        /// 返回值
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 返回码
        /// </summary>
        [XmlElement("retcode")]
        public string Retcode { get; set; }

        /// <summary>
        /// 返回详细码
        /// </summary>
        [XmlElement("retcodesub")]
        public string Retcodesub { get; set; }

        /// <summary>
        /// 返回信息
        /// </summary>
        [XmlElement("retmessage")]
        public string Retmessage { get; set; }

        /// <summary>
        /// 返回详细信息
        /// </summary>
        [XmlElement("retmessagesub")]
        public string Retmessagesub { get; set; }
    }
}
