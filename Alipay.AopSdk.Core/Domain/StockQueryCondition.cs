using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// StockQueryCondition Data Structure.
    /// </summary>
    [Serializable]
    public class StockQueryCondition : AopObject
    {
        /// <summary>
        /// 库存查询结束时间
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 站点列表
        /// </summary>
        [XmlArray("position")]
        [XmlArrayItem("position")]
        public List<Position> Position { get; set; }

        /// <summary>
        /// 库存查询起始日期
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
