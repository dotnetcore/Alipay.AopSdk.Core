using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerbaseinfoBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerbaseinfoBatchqueryModel : AopObject
    {
        /// <summary>
        /// 租户code，alipay or taobao
        /// </summary>
        [XmlElement("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 小程序id列表
        /// </summary>
        [XmlArray("mini_app_id_list")]
        [XmlArrayItem("mini_app_base_info_query_info")]
        public List<MiniAppBaseInfoQueryInfo> MiniAppIdList { get; set; }
    }
}
