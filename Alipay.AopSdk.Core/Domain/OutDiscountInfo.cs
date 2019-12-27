using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// OutDiscountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OutDiscountInfo : AopObject
    {
        /// <summary>
        /// 优惠金额，单位：分
        /// </summary>
        [XmlElement("discount_amount")]
        public long DiscountAmount { get; set; }

        /// <summary>
        /// 优惠名称
        /// </summary>
        [XmlElement("discount_name")]
        public string DiscountName { get; set; }

        /// <summary>
        /// 优惠类型，必须是以下类型：  EXCLUSIVE_BENEFIT("专享优惠"),  EXCLUSIVE_DISCOUNT("专享折扣"),  APPRECIATION_BENEFIT("增值权益"),  MEMBER_POINT("会员积分");
        /// </summary>
        [XmlElement("discount_type")]
        public string DiscountType { get; set; }
    }
}
