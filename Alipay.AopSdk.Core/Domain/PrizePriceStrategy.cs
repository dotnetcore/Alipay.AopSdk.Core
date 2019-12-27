using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// PrizePriceStrategy Data Structure.
    /// </summary>
    [Serializable]
    public class PrizePriceStrategy : AopObject
    {
        /// <summary>
        /// 根据不同的奖品类型填写不同的值，具体用法联系营销技术获取
        /// </summary>
        [XmlElement("max_price")]
        public string MaxPrice { get; set; }

        /// <summary>
        /// 根据不同的奖品类型填写不同的值，具体用法联系营销技术获取
        /// </summary>
        [XmlElement("min_price")]
        public string MinPrice { get; set; }

        /// <summary>
        /// 定价策略值，根据不同的奖品类型填写不同的值，具体用法联系营销技术获取
        /// </summary>
        [XmlElement("stragety_value")]
        public string StragetyValue { get; set; }

        /// <summary>
        /// RANDOM_PRICE随机，FIX_PRICE定额奖品，不同的定价策略填写不同值，具体根据业务评估
        /// </summary>
        [XmlElement("strategy_type")]
        public string StrategyType { get; set; }
    }
}
