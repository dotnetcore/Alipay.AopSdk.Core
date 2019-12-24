using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionInfoDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerversionInfoDeleteModel : AopObject
    {
        /// <summary>
        /// 业务场景来源
        /// </summary>
        [XmlElement("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 小程序版本号
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 端信息
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 操作者ID
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }
    }
}
