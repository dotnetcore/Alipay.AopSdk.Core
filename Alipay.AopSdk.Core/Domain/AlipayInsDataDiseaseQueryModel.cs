using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayInsDataDiseaseQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsDataDiseaseQueryModel : AopObject
    {
        /// <summary>
        /// 疾病名称
        /// </summary>
        [XmlElement("disease_name")]
        public string DiseaseName { get; set; }

        /// <summary>
        /// 分页使用，页码，1开始
        /// </summary>
        [XmlElement("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 页码大小，最大50
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
