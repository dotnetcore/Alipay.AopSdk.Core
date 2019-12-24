using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayCommerceAppPageUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAppPageUploadModel : AopObject
    {
        /// <summary>
        /// 租户应用服务数据
        /// </summary>
        [XmlElement("content")]
        public CommerceAppUploadRequestContent Content { get; set; }

        /// <summary>
        /// 租户应用服务名称
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }
    }
}
