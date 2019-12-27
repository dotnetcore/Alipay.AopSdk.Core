using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// VehicleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VehicleInfo : AopObject
    {
        /// <summary>
        /// 保险公司ID
        /// </summary>
        [XmlElement("company_id")]
        public string CompanyId { get; set; }

        /// <summary>
        /// 保险公司对应的精友码（转码）
        /// </summary>
        [XmlElement("vehicle_code")]
        public string VehicleCode { get; set; }

        /// <summary>
        /// 精友码提供者在精友的主体编码
        /// </summary>
        [XmlElement("vehicle_subject_code")]
        public string VehicleSubjectCode { get; set; }
    }
}
