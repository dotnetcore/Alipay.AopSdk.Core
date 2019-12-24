using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ApplyCodeResult Data Structure.
    /// </summary>
    [Serializable]
    public class ApplyCodeResult : AopObject
    {
        /// <summary>
        /// biz_id，唯一，业务id，用于业务请求的幂等标志
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// code_result，S码申请成功的结果
        /// </summary>
        [XmlElement("code_result")]
        public CodeResult CodeResult { get; set; }

        /// <summary>
        /// error_code，错误的code，用于区分错误的类型
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// error_message，错误描述，用来描述错误的具体原因
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// success，表达该请求实例是否成功，true：成功，false：失败
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
