using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerversionBatchqueryModel : AopObject
    {
        /// <summary>
        /// 端参数，可不选，默认支付宝端 枚举列举：支付宝：com.alipay.alipaywallet，高德：com.amap.app
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序版本号
        /// </summary>
        [XmlArray("version_list")]
        [XmlArrayItem("mini_app_version_query_info")]
        public List<MiniAppVersionQueryInfo> VersionList { get; set; }
    }
}
