using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MybankCreditLoanapplyQrcodeInvalidDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoanapplyQrcodeInvalidDeleteModel : AopObject
    {
        /// <summary>
        /// 需要失效的二维码的加密 token 信息
        /// </summary>
        [XmlElement("encrypt_token")]
        public string EncryptToken { get; set; }
    }
}
