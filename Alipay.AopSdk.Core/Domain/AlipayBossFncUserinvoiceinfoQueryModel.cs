using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayBossFncUserinvoiceinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncUserinvoiceinfoQueryModel : AopObject
    {
        /// <summary>
        /// 开票pid/mid/ou，唯一标识商户信息/集团用户信息的ID
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }
    }
}
