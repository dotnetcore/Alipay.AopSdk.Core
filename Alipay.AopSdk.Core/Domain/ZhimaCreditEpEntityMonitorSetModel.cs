using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ZhimaCreditEpEntityMonitorSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpEntityMonitorSetModel : AopObject
    {
        /// <summary>
        /// 联系人列表
        /// </summary>
        [XmlElement("contact_list")]
        public string ContactList { get; set; }

        /// <summary>
        /// 方案ID
        /// </summary>
        [XmlElement("solution_id")]
        public string SolutionId { get; set; }
    }
}
