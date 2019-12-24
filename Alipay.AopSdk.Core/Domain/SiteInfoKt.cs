using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// SiteInfoKt Data Structure.
    /// </summary>
    [Serializable]
    public class SiteInfoKt : AopObject
    {
        /// <summary>
        /// 测试账号
        /// </summary>
        [XmlElement("account")]
        public string Account { get; set; }

        /// <summary>
        /// 测试密码
        /// </summary>
        [XmlElement("password")]
        public string Password { get; set; }

        /// <summary>
        /// 站点名称
        /// </summary>
        [XmlElement("site_name")]
        public string SiteName { get; set; }

        /// <summary>
        /// 网站：01&#160;&#8232;APP : 02&#160;&#8232;服务窗:03&#160;&#8232;公众号:04&#160;&#8232;其他:05&#160;&#8232;支付宝小程序:06
        /// </summary>
        [XmlElement("site_type")]
        public string SiteType { get; set; }

        /// <summary>
        /// 站点地址
        /// </summary>
        [XmlElement("site_url")]
        public string SiteUrl { get; set; }
    }
}
