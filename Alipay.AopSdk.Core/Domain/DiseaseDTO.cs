using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// DiseaseDTO Data Structure.
    /// </summary>
    [Serializable]
    public class DiseaseDTO : AopObject
    {
        /// <summary>
        /// 疾病标准编码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 疾病标准名称
        /// </summary>
        [XmlElement("disease_name")]
        public string DiseaseName { get; set; }
    }
}
