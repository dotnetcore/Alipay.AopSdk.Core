using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// OfflineInviteNewerDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OfflineInviteNewerDetailInfo : AopObject
    {
        /// <summary>
        /// 城市
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 扩展信息字段
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 被邀请手机号
        /// </summary>
        [XmlElement("invited_phone")]
        public string InvitedPhone { get; set; }

        /// <summary>
        /// 地域系数
        /// </summary>
        [XmlElement("lbs_rate")]
        public string LbsRate { get; set; }

        /// <summary>
        /// 二级渠道
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 一级渠道
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [XmlElement("province_name")]
        public string ProvinceName { get; set; }

        /// <summary>
        /// 是否可结算核销用户
        /// </summary>
        [XmlElement("settled")]
        public bool Settled { get; set; }

        /// <summary>
        /// 是否可结算的绑卡用户
        /// </summary>
        [XmlElement("settled_and_bind")]
        public bool SettledAndBind { get; set; }

        /// <summary>
        /// 绑卡时间
        /// </summary>
        [XmlElement("user_bind_card_time")]
        public string UserBindCardTime { get; set; }

        /// <summary>
        /// 用户实名时间
        /// </summary>
        [XmlElement("user_cert_time")]
        public string UserCertTime { get; set; }

        /// <summary>
        /// 用户领奖时间
        /// </summary>
        [XmlElement("user_prize_time")]
        public string UserPrizeTime { get; set; }
    }
}
