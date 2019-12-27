using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// Address Data Structure.
    /// </summary>
    [Serializable]
    public class Address : AopObject
    {
        /// <summary>
        /// city，市名
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// county，用于区、县的描述
        /// </summary>
        [XmlElement("county")]
        public string County { get; set; }

        /// <summary>
        /// detail，地址详情
        /// </summary>
        [XmlElement("detail")]
        public string Detail { get; set; }

        /// <summary>
        /// province，省份
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }
    }
}
