using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayEbppFlowQualificationDetectModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppFlowQualificationDetectModel : AopObject
    {
        /// <summary>
        /// 需要校验的用户手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 需要校验的产品id
        /// </summary>
        [XmlArray("product_id")]
        [XmlArrayItem("string")]
        public List<string> ProductId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
