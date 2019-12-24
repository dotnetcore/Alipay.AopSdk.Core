using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipaySecurityRiskContentDetectModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskContentDetectModel : AopObject
    {
        /// <summary>
        /// 需要识别的文本，不要包含特殊字符以及双引号等可能引起json格式化错误问题的字符.
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }
    }
}
