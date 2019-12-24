using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionContentRollbackModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerversionContentRollbackModel : AopObject
    {
        /// <summary>
        /// 业务场景来源
        /// </summary>
        [XmlElement("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 小程序当前上架版本号
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 端
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序所属主体
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }
    }
}
