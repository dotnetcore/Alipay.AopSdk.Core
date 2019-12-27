using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ZhimaCustomerEpIdentificationCertifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCustomerEpIdentificationCertifyModel : AopObject
    {
        /// <summary>
        /// 一次认证的唯一标识，在完成企业认证初始化后可以获取。
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }
    }
}
