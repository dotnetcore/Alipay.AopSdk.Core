using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// DefaultInCartInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DefaultInCartInfo : AopObject
    {
        /// <summary>
        /// 如果不设置就餐人数，该字段必填，代表开台菜的默认必点数量。
        /// </summary>
        [XmlElement("default_num")]
        public long DefaultNum { get; set; }

        /// <summary>
        /// true/false。表示该条开台菜必点数量是否关联就餐人数。
        /// </summary>
        [XmlElement("link_guest")]
        public bool LinkGuest { get; set; }

        /// <summary>
        /// 如果关联就餐人数，该项必填，代表每个人开台菜的必点数量。
        /// </summary>
        [XmlElement("per_num")]
        public long PerNum { get; set; }
    }
}
