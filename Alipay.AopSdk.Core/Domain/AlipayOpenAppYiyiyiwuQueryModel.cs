using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenAppYiyiyiwuQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppYiyiyiwuQueryModel : AopObject
    {
        /// <summary>
        /// 12
        /// </summary>
        [XmlElement("rucan")]
        public string Rucan { get; set; }
    }
}
