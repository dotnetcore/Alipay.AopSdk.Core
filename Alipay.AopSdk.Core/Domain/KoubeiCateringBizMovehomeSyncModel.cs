using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiCateringBizMovehomeSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringBizMovehomeSyncModel : AopObject
    {
        /// <summary>
        /// leads信息列表
        /// </summary>
        [XmlArray("leads_info_list")]
        [XmlArrayItem("kcp_leads_info")]
        public List<KcpLeadsInfo> LeadsInfoList { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }
    }
}
