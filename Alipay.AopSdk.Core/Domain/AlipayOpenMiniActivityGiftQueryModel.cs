using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenMiniActivityGiftQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniActivityGiftQueryModel : AopObject
    {
        /// <summary>
        /// 小程序活动id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 券跳转地址类型
        /// </summary>
        [XmlElement("voucher_jump_type")]
        public string VoucherJumpType { get; set; }
    }
}
