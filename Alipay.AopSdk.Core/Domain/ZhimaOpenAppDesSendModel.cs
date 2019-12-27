using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ZhimaOpenAppDesSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaOpenAppDesSendModel : AopObject
    {
        /// <summary>
        /// 21
        /// </summary>
        [XmlElement("com")]
        public GavintestNewLeveaOne Com { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("test")]
        public string Test { get; set; }
    }
}
