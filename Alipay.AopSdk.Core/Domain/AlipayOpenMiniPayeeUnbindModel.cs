using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenMiniPayeeUnbindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniPayeeUnbindModel : AopObject
    {
        /// <summary>
        /// 支付宝登陆账号,和pid两者必选其一，小程序如收款pid与小程序PID非同主体，则只支持通过pid解绑
        /// </summary>
        [XmlElement("logonid")]
        public string Logonid { get; set; }

        /// <summary>
        /// 支付宝账号id,和logonid两者必选其一，小程序如收款pid与小程序PID非同主体，则只支持通过pid解绑
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }
    }
}
