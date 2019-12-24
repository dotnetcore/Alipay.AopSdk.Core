using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AddressDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AddressDTO : AopObject
    {
        /// <summary>
        /// POI编码
        /// </summary>
        [XmlElement("poi_code")]
        public string PoiCode { get; set; }

        /// <summary>
        /// POI访问URL
        /// </summary>
        [XmlElement("poi_url")]
        public string PoiUrl { get; set; }
    }
}
