using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayOpenMiniVersionListQueryResponse.
    /// </summary>
    public class AlipayOpenMiniVersionListQueryResponse : AopResponse
    {
        /// <summary>
        /// 小程序的版本号列表
        /// </summary>
        [XmlArray("app_versions")]
        [XmlArrayItem("string")]
        public List<string> AppVersions { get; set; }
    }
}
