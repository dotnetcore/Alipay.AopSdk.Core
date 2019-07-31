using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// ZolozAuthenticationCustomerFaceverifyMatchResponse.
    /// </summary>
    public class ZolozAuthenticationCustomerFaceverifyMatchResponse : AopResponse
    {
        /// <summary>
        /// 是否为攻击
        /// </summary>
        [XmlElement("attack")]
        public bool Attack { get; set; }

        /// <summary>
        /// 人脸比对结果：成功或者失败
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
