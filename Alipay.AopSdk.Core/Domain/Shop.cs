using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// Shop Data Structure.
    /// </summary>
    [Serializable]
    public class Shop : AopObject
    {
        /// <summary>
        /// 地址信息
        /// </summary>
        [XmlElement("address")]
        public Address Address { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 门店类型，只能选择SMID/MID/PID其中一个
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
