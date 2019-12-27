using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipaySecurityRiskHufuAuthCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskHufuAuthCreateModel : AopObject
    {
        /// <summary>
        /// 虎符认证成功后的回调地址
        /// </summary>
        [XmlElement("callback")]
        public string Callback { get; set; }

        /// <summary>
        /// 虎符提供的高级策略配置
        /// </summary>
        [XmlElement("policy")]
        public string Policy { get; set; }

        /// <summary>
        /// 接入应用的流水号，用于问题的排查等
        /// </summary>
        [XmlElement("serial")]
        public string Serial { get; set; }

        /// <summary>
        /// 用户可选的虎符认证类型
        /// </summary>
        [XmlElement("strategies")]
        public string Strategies { get; set; }

        /// <summary>
        /// 用户的唯一标识id，这个id是接入应用的用户id，虎符的认证会利用这个id来智能检测用户的设备安全信息
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }

        /// <summary>
        /// 需要认证的用户参数，如短信需要提供手机号
        /// </summary>
        [XmlElement("user")]
        public string User { get; set; }
    }
}
