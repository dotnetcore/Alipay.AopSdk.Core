using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOverseasTravelContentCountSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTravelContentCountSyncModel : AopObject
    {
        /// <summary>
        /// 计数信息列表
        /// </summary>
        [XmlArray("count_infos")]
        [XmlArrayItem("count_info")]
        public List<CountInfo> CountInfos { get; set; }
    }
}
