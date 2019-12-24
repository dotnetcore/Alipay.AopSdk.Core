using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// WhitehatInfo Data Structure.
    /// </summary>
    [Serializable]
    public class WhitehatInfo : AopObject
    {
        /// <summary>
        /// 当前有效的安全币奖励
        /// </summary>
        [XmlElement("coin")]
        public long Coin { get; set; }

        /// <summary>
        /// 历史总金币奖励
        /// </summary>
        [XmlElement("history_coin")]
        public long HistoryCoin { get; set; }

        /// <summary>
        /// 称号
        /// </summary>
        [XmlElement("level")]
        public string Level { get; set; }
    }
}
