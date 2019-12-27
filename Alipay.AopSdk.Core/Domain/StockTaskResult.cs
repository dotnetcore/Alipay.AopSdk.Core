using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// StockTaskResult Data Structure.
    /// </summary>
    [Serializable]
    public class StockTaskResult : AopObject
    {
        /// <summary>
        /// 售价方式：CPP（按人次保量）、CPT（按时长售卖）
        /// </summary>
        [XmlElement("charge_type")]
        public long ChargeType { get; set; }

        /// <summary>
        /// 库存任务创建时间
        /// </summary>
        [XmlElement("query_time")]
        public string QueryTime { get; set; }

        /// <summary>
        /// 售卖方式，枚举值1:GD（保量）、2:RTB（竞价）
        /// </summary>
        [XmlElement("sell_mode")]
        public long SellMode { get; set; }

        /// <summary>
        /// 库存查询量
        /// </summary>
        [XmlArray("stock_quantity")]
        [XmlArrayItem("stock_quantity")]
        public List<StockQuantity> StockQuantity { get; set; }

        /// <summary>
        /// 库存任务查询条件
        /// </summary>
        [XmlElement("stock_query_condition")]
        public StockQueryCondition StockQueryCondition { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [XmlElement("task_id")]
        public long TaskId { get; set; }

        /// <summary>
        /// 单价：CPP模式下 分/千人次， CPT模式下 分/秒）
        /// </summary>
        [XmlElement("unit_price")]
        public long UnitPrice { get; set; }
    }
}
