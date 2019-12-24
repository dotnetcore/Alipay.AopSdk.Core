using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerbaseinfoDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerbaseinfoDeleteModel : AopObject
    {
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
