using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AftFinsecureRiskplusSecurityPolicyQueryResponse.
    /// </summary>
    public class AftFinsecureRiskplusSecurityPolicyQueryResponse : AopResponse
    {
        /// <summary>
        /// 风险咨询情况下返回的风险等级，风险处理不会返回该值
        /// </summary>
        [XmlElement("level")]
        public long Level { get; set; }

        /// <summary>
        /// 反馈成功之后的id
        /// </summary>
        [XmlElement("security_id")]
        public string SecurityId { get; set; }

        /// <summary>
        /// 安全处理结果，枚举值为：reject[拒绝],validate[校验],accept[放过]
        /// </summary>
        [XmlElement("security_result")]
        public string SecurityResult { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public string Success { get; set; }

        /// <summary>
        /// 有风险需要失败业务情况下的返回码
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }

        /// <summary>
        /// 有风险需要失败业务情况下的返回码描述
        /// </summary>
        [XmlElement("template_desc")]
        public string TemplateDesc { get; set; }

        /// <summary>
        /// native场景下的核身id
        /// </summary>
        [XmlElement("verify_id")]
        public string VerifyId { get; set; }

        /// <summary>
        /// h5场景下的核身地址
        /// </summary>
        [XmlElement("verify_url")]
        public string VerifyUrl { get; set; }
    }
}
