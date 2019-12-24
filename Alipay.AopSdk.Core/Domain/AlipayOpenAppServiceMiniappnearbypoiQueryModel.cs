using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenAppServiceMiniappnearbypoiQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppServiceMiniappnearbypoiQueryModel : AopObject
    {
        /// <summary>
        /// poiCode列表
        /// </summary>
        [XmlArray("poi_code_list")]
        [XmlArrayItem("string")]
        public List<string> PoiCodeList { get; set; }

        /// <summary>
        /// 服务编码
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }
    }
}
