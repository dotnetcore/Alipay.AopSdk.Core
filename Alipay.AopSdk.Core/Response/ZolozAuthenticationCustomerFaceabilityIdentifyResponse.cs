using System;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// ZolozAuthenticationCustomerFaceabilityIdentifyResponse.
    /// </summary>
    public class ZolozAuthenticationCustomerFaceabilityIdentifyResponse : AopResponse
    {
        /// <summary>
        /// 能力接口返回值
        /// </summary>
        [XmlElement("biz_info")]
        public FaceAbilityExtInfo BizInfo { get; set; }
    }
}
