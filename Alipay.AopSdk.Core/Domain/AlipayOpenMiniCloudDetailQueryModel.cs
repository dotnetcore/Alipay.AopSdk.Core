using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenMiniCloudDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniCloudDetailQueryModel : AopObject
    {
        /// <summary>
        /// 应用的appid。partner_id和mini_appid不能同时为空。
        /// </summary>
        [XmlElement("mini_appid")]
        public string MiniAppid { get; set; }

        /// <summary>
        /// 商户和支付宝交互时，支付宝分配给商户ID。partner_id和mini_appid不能同时为空。
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }
    }
}
