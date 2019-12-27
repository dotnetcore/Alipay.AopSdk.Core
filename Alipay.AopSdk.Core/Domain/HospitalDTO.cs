using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// HospitalDTO Data Structure.
    /// </summary>
    [Serializable]
    public class HospitalDTO : AopObject
    {
        /// <summary>
        /// 医院标准名称
        /// </summary>
        [XmlElement("hospital_name")]
        public string HospitalName { get; set; }

        /// <summary>
        /// 医院等级，一级医院、二级医院、三级医院、其他
        /// </summary>
        [XmlElement("level")]
        public string Level { get; set; }

        /// <summary>
        /// 医院性质：公立医院、私立医院、其他
        /// </summary>
        [XmlElement("ownership")]
        public string Ownership { get; set; }
    }
}
