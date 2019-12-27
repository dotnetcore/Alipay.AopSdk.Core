using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenMiniVersionRollbackModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniVersionRollbackModel : AopObject
    {
        /// <summary>
        /// 小程序版本号
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 端参数，可不传。默认支付宝端
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }
    }
}
