using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// PoiSyncData Data Structure.
    /// </summary>
    [Serializable]
    public class PoiSyncData : AopObject
    {
        /// <summary>
        /// 小程序appId
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// poi的id
        /// </summary>
        [XmlArray("poi_codes")]
        [XmlArrayItem("string")]
        public List<string> PoiCodes { get; set; }

        /// <summary>
        /// 12
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
