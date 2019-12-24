using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenMiniBaseinfoMultiQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniBaseinfoMultiQueryModel : AopObject
    {
        /// <summary>
        /// 应用端信息
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
