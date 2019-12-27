using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayUserPortraitQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserPortraitQueryModel : AopObject
    {
        /// <summary>
        /// 1688端传递havanaId的列表过来，单次传递不超过2个
        /// </summary>
        [XmlArray("havana_id")]
        [XmlArrayItem("string")]
        public List<string> HavanaId { get; set; }
    }
}
