using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// VoucherInfoDetail Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherInfoDetail : AopObject
    {
        /// <summary>
        /// ISTORE拿铁满50减10券
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 失效时间。格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("expired_time")]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// 券ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 券名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 券状态。VALID：有效，表示可用；INVALID：无效，由于过期等券自身原因导致的不可用；UNAVAILABLE：条件未满足导致的不可用，比如用户指定使用，但是因为条件未达到，比如金额、商品等。
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 生效时间。格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("valid_time")]
        public string ValidTime { get; set; }

        /// <summary>
        /// 券值，根据券类型而定，比如满减：10，折扣：0.9(九折)
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
