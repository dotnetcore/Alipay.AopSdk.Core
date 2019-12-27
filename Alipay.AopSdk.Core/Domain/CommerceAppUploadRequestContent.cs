using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// CommerceAppUploadRequestContent Data Structure.
    /// </summary>
    [Serializable]
    public class CommerceAppUploadRequestContent : AopObject
    {
        /// <summary>
        /// 租户应用业务流程ID
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 租户应用业务流程内容
        /// </summary>
        [XmlElement("body")]
        public string Body { get; set; }

        /// <summary>
        /// 查询条件
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }

        /// <summary>
        /// 租户应用ID
        /// </summary>
        [XmlElement("tenant_app_id")]
        public string TenantAppId { get; set; }
    }
}
