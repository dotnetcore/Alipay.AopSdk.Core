using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayUserGroupshoppingBenefitQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserGroupshoppingBenefitQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝淘宝拼团的组团id
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 拼团是否混合出资
        /// </summary>
        [XmlElement("is_platform_invest")]
        public bool IsPlatformInvest { get; set; }

        /// <summary>
        /// 淘宝支付宝拼团的商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 拼团原始价格
        /// </summary>
        [XmlElement("original_prize")]
        public string OriginalPrize { get; set; }

        /// <summary>
        /// 拼团的价格
        /// </summary>
        [XmlElement("pin_prize")]
        public string PinPrize { get; set; }

        /// <summary>
        /// 1表示拼团中；2表示拼团成功；3表示拼团失败
        /// </summary>
        [XmlElement("pin_status")]
        public string PinStatus { get; set; }

        /// <summary>
        /// DETAIL_PAGE拼团详情页，FINISH_PAGE拼团成功页
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 当前已参团的用户id
        /// </summary>
        [XmlArray("user_id_list")]
        [XmlArrayItem("string")]
        public List<string> UserIdList { get; set; }
    }
}
