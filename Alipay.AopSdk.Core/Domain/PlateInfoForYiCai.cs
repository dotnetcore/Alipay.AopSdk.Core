using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// PlateInfoForYiCai Data Structure.
    /// </summary>
    [Serializable]
    public class PlateInfoForYiCai : AopObject
    {
        /// <summary>
        /// 板块所属类型
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 板块的ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 板块名称
        /// </summary>
        [XmlElement("plate_name")]
        public string PlateName { get; set; }

        /// <summary>
        /// 股票代码和股票名称
        /// </summary>
        [XmlArray("symbol_name")]
        [XmlArrayItem("string")]
        public List<string> SymbolName { get; set; }
    }
}
