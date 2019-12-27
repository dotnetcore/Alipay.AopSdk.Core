using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiRetailWmsPartnerQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsPartnerQueryModel : AopObject
    {
        /// <summary>
        /// 操作上下文
        /// </summary>
        [XmlElement("operate_context")]
        public OperateContext OperateContext { get; set; }

        /// <summary>
        /// 商户ID，限制批量查询100个ID
        /// </summary>
        [XmlArray("partner_ids")]
        [XmlArrayItem("string")]
        public List<string> PartnerIds { get; set; }
    }
}
