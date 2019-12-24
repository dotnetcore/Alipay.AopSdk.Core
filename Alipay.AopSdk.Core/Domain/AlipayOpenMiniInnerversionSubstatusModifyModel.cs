using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionSubstatusModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerversionSubstatusModifyModel : AopObject
    {
        /// <summary>
        /// 小程序开发版本
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 端标识 淘宝：com.taobao.app 支付宝：com.alipay.alipaywallet
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 租户编码
        /// </summary>
        [XmlElement("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 子状态
        /// </summary>
        [XmlElement("sub_status")]
        public string SubStatus { get; set; }
    }
}
