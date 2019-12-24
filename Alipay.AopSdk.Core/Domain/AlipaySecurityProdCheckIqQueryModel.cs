using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipaySecurityProdCheckIqQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdCheckIqQueryModel : AopObject
    {
        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }
    }
}
