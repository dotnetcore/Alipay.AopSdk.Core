using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ZolozIdentificationCustomerCertifyzhubQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZolozIdentificationCustomerCertifyzhubQueryModel : AopObject
    {
        /// <summary>
        /// 业务单据号，用于核对和排查
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 0：匿名注册  1：匿名认证   2：实名认证
        /// </summary>
        [XmlElement("face_type")]
        public long FaceType { get; set; }

        /// <summary>
        /// 是否需要返回人脸图片
        /// </summary>
        [XmlElement("need_img")]
        public bool NeedImg { get; set; }

        /// <summary>
        /// zimId，用于查询认证结果
        /// </summary>
        [XmlElement("zim_id")]
        public string ZimId { get; set; }
    }
}
