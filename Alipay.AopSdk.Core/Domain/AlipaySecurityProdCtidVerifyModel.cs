using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipaySecurityProdCtidVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdCtidVerifyModel : AopObject
    {
        /// <summary>
        /// 身份证号码
        /// </summary>
        [XmlElement("id_number")]
        public string IdNumber { get; set; }

        /// <summary>
        /// 认证模式
        /// </summary>
        [XmlElement("identify_model")]
        public string IdentifyModel { get; set; }

        /// <summary>
        /// 图片的base64编码
        /// </summary>
        [XmlElement("picture")]
        public string Picture { get; set; }

        /// <summary>
        /// 个人用户姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
