using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// CloudbusPredictResult Data Structure.
    /// </summary>
    [Serializable]
    public class CloudbusPredictResult : AopObject
    {
        /// <summary>
        /// 执行任务状态描述
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 进度50%
        /// </summary>
        [XmlElement("progress")]
        public long Progress { get; set; }

        /// <summary>
        /// 预测线路
        /// </summary>
        [XmlArray("routes")]
        [XmlArrayItem("cloudbus_route_r_item")]
        public List<CloudbusRouteRItem> Routes { get; set; }

        /// <summary>
        /// 影响下降线路
        /// </summary>
        [XmlArray("routes_decreased")]
        [XmlArrayItem("cloudbus_route_r_item")]
        public List<CloudbusRouteRItem> RoutesDecreased { get; set; }

        /// <summary>
        /// 客流预测影响下降线路
        /// </summary>
        [XmlArray("routes_increased")]
        [XmlArrayItem("cloudbus_route_r_item")]
        public List<CloudbusRouteRItem> RoutesIncreased { get; set; }

        /// <summary>
        /// 任务状态：0：准备 1：运行中 2：成功 3： 失败： 4：终止 5： 其他
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }
    }
}
