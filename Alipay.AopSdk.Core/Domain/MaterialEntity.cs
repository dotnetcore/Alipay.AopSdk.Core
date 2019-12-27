using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MaterialEntity Data Structure.
    /// </summary>
    [Serializable]
    public class MaterialEntity : AopObject
    {
        /// <summary>
        /// 配料id
        /// </summary>
        [XmlElement("material_id")]
        public string MaterialId { get; set; }

        /// <summary>
        /// 配料名称
        /// </summary>
        [XmlElement("material_name")]
        public string MaterialName { get; set; }

        /// <summary>
        /// 加价金额
        /// </summary>
        [XmlElement("sell_price")]
        public string SellPrice { get; set; }
    }
}
