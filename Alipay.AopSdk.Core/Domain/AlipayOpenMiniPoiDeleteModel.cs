using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenMiniPoiDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniPoiDeleteModel : AopObject
    {
        /// <summary>
        /// poi id，地理位置标记信息
        /// </summary>
        [XmlElement("poi_id")]
        public string PoiId { get; set; }
    }
}
