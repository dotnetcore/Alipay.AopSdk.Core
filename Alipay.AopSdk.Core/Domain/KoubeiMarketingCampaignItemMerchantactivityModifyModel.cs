using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignItemMerchantactivityModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignItemMerchantactivityModifyModel : AopObject
    {
        /// <summary>
        /// 活动Id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 外部回调地址
        /// </summary>
        [XmlElement("external_callback_url")]
        public string ExternalCallbackUrl { get; set; }

        /// <summary>
        /// 活动结束日期，只可以延长  格式要求为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 活动商品列表，只可以增加
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
        /// 券信息，可修改logo/userIntroductions ，validTimeRangeTo只可延长，validDaysRangeTo只可延长
        /// </summary>
        [XmlElement("voucher_info")]
        public MerchantActivityModifyVoucherInfo VoucherInfo { get; set; }
    }
}
