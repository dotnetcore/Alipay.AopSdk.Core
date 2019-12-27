using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignPrizepoolPrizeDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignPrizepoolPrizeDeleteModel : AopObject
    {
        /// <summary>
        /// 外部业务流水号，用来标识唯 一的业务动作，用于幂等
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 奖品池id，使用前请联系业务 对接同学提供
        /// </summary>
        [XmlElement("pool_id")]
        public string PoolId { get; set; }

        /// <summary>
        /// 奖品id，从奖品池内删除的奖品标识
        /// </summary>
        [XmlElement("prize_id")]
        public string PrizeId { get; set; }

        /// <summary>
        /// 表示业务来源，由营销技术提 供具体值
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// PRIZE_PAUSED("PRIZE_PAUSED", "暂停状态"), PRIZE_CLOSED("PRIZE_CLOSED", "关闭状态"); 参数为空，默认暂停状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
