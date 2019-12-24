using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// PaymentSuccessPagePlanInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PaymentSuccessPagePlanInfo : AopObject
    {
        /// <summary>
        /// 创建支付后推荐方案时填写的收藏有礼活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 有礼活动状态，目前返回的状态枚举值包括：NOT_WORKING(非进行中)，WORKING(进行中)，NO_COUPON_LIFT(券剩余量为0)
        /// </summary>
        [XmlElement("activity_status")]
        public string ActivityStatus { get; set; }

        /// <summary>
        /// 支付后推荐开始时间
        /// </summary>
        [XmlElement("begin_time")]
        public string BeginTime { get; set; }

        /// <summary>
        /// 支付后推荐方案结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 支付后推荐应用id，当type=TINYAPP，则为小程序应用id；当type=PUBLICAPP,则为生活号应用id
        /// </summary>
        [XmlElement("oper_app_id")]
        public string OperAppId { get; set; }

        /// <summary>
        /// 支付后推荐方案ID，用以唯一标识方案
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 支付后推荐方案名称，用以描述方案的名字
        /// </summary>
        [XmlElement("plan_name")]
        public string PlanName { get; set; }

        /// <summary>
        /// 支付后推荐方案优先级，目前仅支持0和1两个枚举值，其中数值越大优先级越高
        /// </summary>
        [XmlElement("priority")]
        public string Priority { get; set; }

        /// <summary>
        /// 用户提交创建支付后推荐方案后，被蚂蚁小二审核拒绝的原因
        /// </summary>
        [XmlElement("reject_reason")]
        public string RejectReason { get; set; }

        /// <summary>
        /// 创建支付后推荐方案时填写的可用的服务能力标签数组
        /// </summary>
        [XmlArray("service_list")]
        [XmlArrayItem("string")]
        public List<string> ServiceList { get; set; }

        /// <summary>
        /// 支付后推荐方案状态，目前支持的枚举值如下：审核中--AUDITING;进行中--WORKING;被驳回--REJECTED;已结束--FINISHED
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 支付后推荐类型，目前只支持小程序和生活号的推荐
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
