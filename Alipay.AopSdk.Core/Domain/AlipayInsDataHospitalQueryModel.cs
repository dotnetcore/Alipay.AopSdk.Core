using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayInsDataHospitalQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsDataHospitalQueryModel : AopObject
    {
        /// <summary>
        /// 医院所在的地市名称
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 医院名称
        /// </summary>
        [XmlElement("hospital_name")]
        public string HospitalName { get; set; }
    }
}
