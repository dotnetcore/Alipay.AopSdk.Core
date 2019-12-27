using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// PrincipalForOpenapi Data Structure.
    /// </summary>
    [Serializable]
    public class PrincipalForOpenapi : AopObject
    {
        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 用户类型
        /// </summary>
        [XmlElement("principal_type")]
        public string PrincipalType { get; set; }
    }
}
