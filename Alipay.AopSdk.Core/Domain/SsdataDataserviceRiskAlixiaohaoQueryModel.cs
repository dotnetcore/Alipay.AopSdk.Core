using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// SsdataDataserviceRiskAlixiaohaoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class SsdataDataserviceRiskAlixiaohaoQueryModel : AopObject
    {
        /// <summary>
        /// 电话号码
        /// </summary>
        [XmlElement("mobile_no")]
        public string MobileNo { get; set; }
    }
}
