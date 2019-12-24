using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipaySecurityDataInfoMobilecityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityDataInfoMobilecityQueryModel : AopObject
    {
        /// <summary>
        /// 电话号码
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }
    }
}
