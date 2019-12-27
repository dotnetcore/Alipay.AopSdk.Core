using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionOnlineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerversionOnlineModel : AopObject
    {
        /// <summary>
        /// 下架版本
        /// </summary>
        [XmlElement("app_offline_version")]
        public string AppOfflineVersion { get; set; }

        /// <summary>
        /// 上架版本
        /// </summary>
        [XmlElement("app_online_version")]
        public string AppOnlineVersion { get; set; }

        /// <summary>
        /// 业务来源
        /// </summary>
        [XmlElement("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 一个端的标识，用于区分不同的客户端，每接入一个客户端，都需要向小程序应用中心申请bundelId入驻
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 租户code，alipay or taobao
        /// </summary>
        [XmlElement("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
