using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// StructureBrandInfo Data Structure.
    /// </summary>
    [Serializable]
    public class StructureBrandInfo : AopObject
    {
        /// <summary>
        /// 品牌英文名
        /// </summary>
        [XmlElement("brand_en_name")]
        public string BrandEnName { get; set; }

        /// <summary>
        /// 品牌英文名
        /// </summary>
        [XmlElement("brand_logo")]
        public string BrandLogo { get; set; }

        /// <summary>
        /// 品牌名
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }
    }
}
