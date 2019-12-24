using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenMiniPoiShowstatusModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniPoiShowstatusModifyModel : AopObject
    {
        /// <summary>
        /// poi id，地理位置标记信息
        /// </summary>
        [XmlElement("poi_id")]
        public string PoiId { get; set; }

        /// <summary>
        /// 是否展示 0 不展示 1展示
        /// </summary>
        [XmlElement("show_status")]
        public string ShowStatus { get; set; }
    }
}
