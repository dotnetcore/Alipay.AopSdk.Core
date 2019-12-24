using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdUserCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdUserCreateModel : AopObject
    {
        /// <summary>
        /// 投放账户支付宝PID
        /// </summary>
        [XmlElement("alipay_pid")]
        public string AlipayPid { get; set; }

        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 账户状态，ENABLE-生效；DISABLE-失效。若为空，则默认有效。
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
