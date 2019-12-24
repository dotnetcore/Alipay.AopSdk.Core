using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignItemMerchantactivityQueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignItemMerchantactivityQueryResponse : AopResponse
    {
        /// <summary>
        /// 活动Id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 营销活动id
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 活动优惠次数限制
        /// </summary>
        [XmlElement("count_limit")]
        public long CountLimit { get; set; }

        /// <summary>
        /// 活动优惠单日次数限制
        /// </summary>
        [XmlElement("count_limit_per_day")]
        public long CountLimitPerDay { get; set; }

        /// <summary>
        /// 活动单用户限次
        /// </summary>
        [XmlElement("count_limit_per_user")]
        public long CountLimitPerUser { get; set; }

        /// <summary>
        /// 活动单用户单日限次
        /// </summary>
        [XmlElement("count_limit_per_user_per_day")]
        public long CountLimitPerUserPerDay { get; set; }

        /// <summary>
        /// 人群规则  DEFAULT：全部用户  ONLINE_NEWCOMER：在线购买新人  MEMBER：会员
        /// </summary>
        [XmlElement("crowd")]
        public string Crowd { get; set; }

        /// <summary>
        /// 代金券面额
        /// </summary>
        [XmlElement("deduct_amount")]
        public string DeductAmount { get; set; }

        /// <summary>
        /// 外部Id
        /// </summary>
        [XmlElement("external_unique_id")]
        public string ExternalUniqueId { get; set; }

        /// <summary>
        /// 活动结束时间  格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 活动开始时间，格式为:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("gmt_start")]
        public string GmtStart { get; set; }

        /// <summary>
        /// 商品列表
        /// </summary>
        [XmlArray("item_ids")]
        [XmlArrayItem("string")]
        public List<string> ItemIds { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 使用门槛，满X元可用，使用门槛必须大于券面额
        /// </summary>
        [XmlElement("min_cost")]
        public string MinCost { get; set; }

        /// <summary>
        /// 是否手动领取，本期只支持true
        /// </summary>
        [XmlElement("obtain_manually")]
        public bool ObtainManually { get; set; }

        /// <summary>
        /// 券信息
        /// </summary>
        [XmlElement("voucher_info")]
        public MerchantActivityVoucherInfo VoucherInfo { get; set; }
    }
}
