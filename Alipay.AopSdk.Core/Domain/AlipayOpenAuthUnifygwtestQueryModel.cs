using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenAuthUnifygwtestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAuthUnifygwtestQueryModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("str")]
        public string Str { get; set; }
    }
}
