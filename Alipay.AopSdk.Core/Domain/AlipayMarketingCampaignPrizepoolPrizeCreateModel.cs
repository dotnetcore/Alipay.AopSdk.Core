using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignPrizepoolPrizeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignPrizepoolPrizeCreateModel : AopObject
    {
        /// <summary>
        /// 当预算类型是数量时，该值表示个数 当预算类型是金额时，该值表示金额，(分)为单位
        /// </summary>
        [XmlElement("budget_amount")]
        public string BudgetAmount { get; set; }

        /// <summary>
        /// COUNT 数量预算 MONEY 金额预算
        /// </summary>
        [XmlElement("budget_type")]
        public string BudgetType { get; set; }

        /// <summary>
        /// 计次配置，具体字段参考CountControlConfig
        /// </summary>
        [XmlArray("count_control_config")]
        [XmlArrayItem("count_control_config")]
        public List<CountControlConfig> CountControlConfig { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [XmlElement("ext_properties")]
        public string ExtProperties { get; set; }

        /// <summary>
        /// 奖品发放开始时间
        /// </summary>
        [XmlElement("gmt_begin")]
        public string GmtBegin { get; set; }

        /// <summary>
        /// 奖品发放结束时间
        /// </summary>
        [XmlElement("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 单次发放系数，默认值1
        /// </summary>
        [XmlElement("modulus")]
        public long Modulus { get; set; }

        /// <summary>
        /// 外部业务流水号，用来标识唯一的业务动作，用于，幂等
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 奖品owner，填写支付宝2088账号
        /// </summary>
        [XmlElement("owner")]
        public string Owner { get; set; }

        /// <summary>
        /// 奖品池id，使用前请联系业务对接同学提供
        /// </summary>
        [XmlElement("pool_id")]
        public string PoolId { get; set; }

        /// <summary>
        /// 奖品名称
        /// </summary>
        [XmlElement("prize_name")]
        public string PrizeName { get; set; }

        /// <summary>
        /// 奖品定价策略,具体见PrizePriceStategy字段
        /// </summary>
        [XmlElement("prize_price_strategy")]
        public PrizePriceStrategy PrizePriceStrategy { get; set; }

        /// <summary>
        /// 子奖品类型，在同一种奖品类型下具体系分不同子类型，具体值联系营销技术获取
        /// </summary>
        [XmlElement("prize_sub_type")]
        public string PrizeSubType { get; set; }

        /// <summary>
        /// 奖品类型，具体值联系营销技术提供，枚举类com.alipay.promokernel.common.service.facade.enums.PrizeTypeEnum
        /// </summary>
        [XmlElement("prize_type")]
        public string PrizeType { get; set; }

        /// <summary>
        /// 表示业务来源，由营销技术提供具体值
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 奖品模板参数，外部奖品的券模板之类的配置信息，用于创建奖品
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
