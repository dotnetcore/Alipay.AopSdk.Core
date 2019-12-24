using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenAppTestapiiSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppTestapiiSyncModel : AopObject
    {
        /// <summary>
        /// v
        /// </summary>
        [XmlElement("in_1")]
        public string In1 { get; set; }

        /// <summary>
        /// b
        /// </summary>
        [XmlElement("in_2")]
        public string In2 { get; set; }
    }
}
