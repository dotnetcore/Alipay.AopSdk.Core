using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// UpdateCodeRequest Data Structure.
    /// </summary>
    [Serializable]
    public class UpdateCodeRequest : AopObject
    {
        /// <summary>
        /// 执行动作，如：绑定-BIND，解绑-UNBIND
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// biz_id，唯一，业务id，用于业务请求的幂等标志
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 码值，对应码平台的token，https://qr.alipay.com/${token}  中的token
        /// </summary>
        [XmlElement("code_token")]
        public string CodeToken { get; set; }

        /// <summary>
        /// context_data，发码的上下文信息，比如子业务code，场景code等。此值为一个Map<string, string>类型的json串字符，传入规则如下： {"key1":"val2","key2":"val2"}。必填业务字段：SUB_BIZ_TYPE，SCENE等，具体咨询对接技术人员
        /// </summary>
        [XmlElement("context_data")]
        public string ContextData { get; set; }
    }
}
