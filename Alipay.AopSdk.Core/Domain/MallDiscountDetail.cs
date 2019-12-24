using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MallDiscountDetail Data Structure.
    /// </summary>
    [Serializable]
    public class MallDiscountDetail : AopObject
    {
        /// <summary>
        /// 优惠金额
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 优惠描述，比如至多优惠XX元，满XX减XX
        /// </summary>
        [XmlArray("discount_desc")]
        [XmlArrayItem("string")]
        public List<string> DiscountDesc { get; set; }

        /// <summary>
        /// 优惠类型,外部优惠（OUT_DISCOUNT），商家优惠（M_DISCOUNT），平台优惠（RT_DISCOUNT）
        /// </summary>
        [XmlElement("discount_type")]
        public string DiscountType { get; set; }

        /// <summary>
        /// 优惠ID或活动ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 优惠名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 是否是购买券, true代表是购买的券，false调表不是购买的券
        /// </summary>
        [XmlElement("purchased")]
        public bool Purchased { get; set; }
    }
}
