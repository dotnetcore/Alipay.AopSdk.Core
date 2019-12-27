using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// IndustryQualificationInfoKt Data Structure.
    /// </summary>
    [Serializable]
    public class IndustryQualificationInfoKt : AopObject
    {
        /// <summary>
        /// 商户行业资质图片URL，格式jpg、jpeg、png
        /// </summary>
        [XmlElement("industry_qualification_image")]
        public string IndustryQualificationImage { get; set; }

        /// <summary>
        /// 商户行业资质类型，具体选值参见https://mif-pub.alipayobjects.com/QualificationType.xlsx
        /// </summary>
        [XmlElement("industry_qualification_type")]
        public string IndustryQualificationType { get; set; }
    }
}
