using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// StockTask Data Structure.
    /// </summary>
    [Serializable]
    public class StockTask : AopObject
    {
        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("ad_user_id")]
        public long AdUserId { get; set; }

        /// <summary>
        /// 库存查询日期
        /// </summary>
        [XmlElement("query_time")]
        public string QueryTime { get; set; }

        /// <summary>
        /// 库存任务状态：0 未开始、1 进行中、2已完成、3 失败
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 库存查询任务id
        /// </summary>
        [XmlElement("task_id")]
        public long TaskId { get; set; }
    }
}
