using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenAppDfsfasDeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppDfsfasDeQueryModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("desd")]
        public string Desd { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("desdde")]
        public string Desdde { get; set; }
    }
}
