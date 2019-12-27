using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// OnlineInviteNewerSummaryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OnlineInviteNewerSummaryInfo : AopObject
    {
        /// <summary>
        /// 返佣的扩展字段
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

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
        /// 日期
        /// </summary>
        [XmlElement("report_date")]
        public string ReportDate { get; set; }

        /// <summary>
        /// 当天有效绑卡数量
        /// </summary>
        [XmlElement("user_bind_card_count")]
        public long UserBindCardCount { get; set; }

        /// <summary>
        /// 可结算实名数
        /// </summary>
        [XmlElement("user_cert_settle_count")]
        public long UserCertSettleCount { get; set; }

        /// <summary>
        /// 可结算新登数
        /// </summary>
        [XmlElement("user_new_settle_count")]
        public long UserNewSettleCount { get; set; }
    }
}
