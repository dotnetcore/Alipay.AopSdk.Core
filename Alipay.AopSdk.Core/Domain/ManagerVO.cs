using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ManagerVO Data Structure.
    /// </summary>
    [Serializable]
    public class ManagerVO : AopObject
    {
        /// <summary>
        /// 管理人员名称
        /// </summary>
        [XmlElement("manager_name")]
        public string ManagerName { get; set; }

        /// <summary>
        /// 职务
        /// </summary>
        [XmlElement("manager_position")]
        public string ManagerPosition { get; set; }
    }
}
