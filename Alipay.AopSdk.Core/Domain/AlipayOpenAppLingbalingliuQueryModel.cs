using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenAppLingbalingliuQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppLingbalingliuQueryModel : AopObject
    {
        /// <summary>
        /// 12
        /// </summary>
        [XmlElement("canshu")]
        public string Canshu { get; set; }
    }
}
