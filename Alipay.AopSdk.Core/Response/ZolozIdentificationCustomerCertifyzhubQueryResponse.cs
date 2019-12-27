using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// ZolozIdentificationCustomerCertifyzhubQueryResponse.
    /// </summary>
    public class ZolozIdentificationCustomerCertifyzhubQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否为攻击
        /// </summary>
        [XmlElement("attack")]
        public bool Attack { get; set; }

        /// <summary>
        /// 业务单据号，用于核对和排查
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 人脸属性信息，提供对人脸base64图片的额外描述，包括不限于人脸矩形框。目前仅为矩形框，无需脱敏。
        /// </summary>
        [XmlElement("face_attr_info")]
        public FaceAttrInfo FaceAttrInfo { get; set; }

        /// <summary>
        /// 图片字节数组进行Base64编码后的字符串
        /// </summary>
        [XmlElement("img_str")]
        public string ImgStr { get; set; }

        /// <summary>
        /// 人脸服务端返回码
        /// </summary>
        [XmlElement("zim_code")]
        public string ZimCode { get; set; }

        /// <summary>
        /// 人脸服务端返回信息
        /// </summary>
        [XmlElement("zim_msg")]
        public string ZimMsg { get; set; }
    }
}
