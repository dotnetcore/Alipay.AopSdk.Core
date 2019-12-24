using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayIserviceCognitiveKgopenQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCognitiveKgopenQueryModel : AopObject
    {
        /// <summary>
        /// 所属在线服务的编码
        /// </summary>
        [XmlElement("online_service_code")]
        public string OnlineServiceCode { get; set; }

        /// <summary>
        /// 查询参数
        /// </summary>
        [XmlArray("params")]
        [XmlArrayItem("map_parameter")]
        public List<MapParameter> Params { get; set; }
    }
}
