using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// CodeResInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CodeResInfo : AopObject
    {
        /// <summary>
        /// 二维码唯一标识id
        /// </summary>
        [XmlElement("code_id")]
        public string CodeId { get; set; }

        /// <summary>
        /// 二维码url地址
        /// </summary>
        [XmlElement("code_url")]
        public string CodeUrl { get; set; }
    }
}
