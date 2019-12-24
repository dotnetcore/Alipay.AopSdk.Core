using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignBenefitSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignBenefitSendModel : AopObject
    {
        /// <summary>
        /// 身份证号码
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 领券渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 优惠类型，CAMPAIGN：活动，ITEM：商品
        /// </summary>
        [XmlElement("discount_type")]
        public string DiscountType { get; set; }

        /// <summary>
        /// 是否需要控制发奖幂等
        /// </summary>
        [XmlElement("idem_camp_trigger")]
        public bool IdemCampTrigger { get; set; }

        /// <summary>
        /// 触发权益的优惠id，当discount_type是ITEM的时候这个内容是商品id，当discount_type是CAMPAIGN的时候这个内容是活动id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 支付宝的登陆账号，可以为邮箱、手机号等。
        /// </summary>
        [XmlElement("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        [XmlElement("mobile_no")]
        public string MobileNo { get; set; }

        /// <summary>
        /// 外部流水号，用于控制幂等
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 领券的门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
