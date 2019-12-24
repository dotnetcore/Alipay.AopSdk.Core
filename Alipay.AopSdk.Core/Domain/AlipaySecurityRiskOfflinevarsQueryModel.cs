using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipaySecurityRiskOfflinevarsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskOfflinevarsQueryModel : AopObject
    {
        /// <summary>
        /// 查询离线变量的主键
        /// </summary>
        [XmlElement("rowkeys")]
        public string Rowkeys { get; set; }
    }
}
