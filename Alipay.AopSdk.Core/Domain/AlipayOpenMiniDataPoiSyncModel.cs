using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenMiniDataPoiSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniDataPoiSyncModel : AopObject
    {
        /// <summary>
        /// poi回流数据
        /// </summary>
        [XmlElement("poi_data")]
        public PoiSyncData PoiData { get; set; }
    }
}
