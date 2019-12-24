using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayInsMarketingExperienceAccountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsMarketingExperienceAccountQueryModel : AopObject
    {
        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 用户2088
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
