using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAntdataassetsPublishtaskCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAntdataassetsPublishtaskCreateModel : AopObject
    {
        /// <summary>
        /// ODPS表的guid
        /// </summary>
        [XmlElement("guid")]
        public string Guid { get; set; }
    }
}
