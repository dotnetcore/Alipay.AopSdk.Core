using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AntfortuneContentCommunityOpenSecuaiQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneContentCommunityOpenSecuaiQueryModel : AopObject
    {
        /// <summary>
        /// 业务的请求参数
        /// </summary>
        [XmlElement("biz_request")]
        public string BizRequest { get; set; }

        /// <summary>
        /// 请求的业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }
    }
}
