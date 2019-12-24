using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AgentOrganization Data Structure.
    /// </summary>
    [Serializable]
    public class AgentOrganization : AopObject
    {
        /// <summary>
        /// 经代下面二级商户id
        /// </summary>
        [XmlElement("agent_merchant_id")]
        public string AgentMerchantId { get; set; }

        /// <summary>
        /// 代理机构(ISV)蚂蚁编码，组织入驻蚂蚁生成的cid
        /// </summary>
        [XmlElement("cid")]
        public string Cid { get; set; }

        /// <summary>
        /// 代理机构(ISV)蚂蚁全称,组织入驻蚂蚂蚁的全称
        /// </summary>
        [XmlElement("cid_name")]
        public string CidName { get; set; }
    }
}
