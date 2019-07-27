using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ZolozAuthenticationCustomerFtokenQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZolozAuthenticationCustomerFtokenQueryModel : AopObject
    {
        /// <summary>
        /// 1、1：1人脸验证能力  2、1：n人脸搜索能力（支付宝uid入库）  3、1：n人脸搜索能力（支付宝手机号入库）  4、手机号和人脸识别综合能力
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 人脸产品拓展参数
        /// </summary>
        [XmlElement("ext_info")]
        public FaceExtInfo ExtInfo { get; set; }

        /// <summary>
        /// 人脸token
        /// </summary>
        [XmlElement("ftoken")]
        public string Ftoken { get; set; }
    }
}
