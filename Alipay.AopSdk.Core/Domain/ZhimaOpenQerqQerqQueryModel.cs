using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ZhimaOpenQerqQerqQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaOpenQerqQerqQueryModel : AopObject
    {
        /// <summary>
        /// 123
        /// </summary>
        [XmlElement("address")]
        public AgreementParams Address { get; set; }
    }
}
