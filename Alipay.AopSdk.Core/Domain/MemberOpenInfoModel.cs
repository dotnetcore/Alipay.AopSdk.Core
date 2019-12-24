using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MemberOpenInfoModel Data Structure.
    /// </summary>
    [Serializable]
    public class MemberOpenInfoModel : AopObject
    {
        /// <summary>
        /// 开卡连接，必须http、https开头
        /// </summary>
        [XmlElement("open_url")]
        public string OpenUrl { get; set; }

        /// <summary>
        /// 微信端开卡链接，不能是alipay域名  如果会员模板支持微信端，则必填
        /// </summary>
        [XmlElement("wechat_open_url")]
        public string WechatOpenUrl { get; set; }
    }
}
