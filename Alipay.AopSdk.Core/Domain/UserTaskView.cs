using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// UserTaskView Data Structure.
    /// </summary>
    [Serializable]
    public class UserTaskView : AopObject
    {
        /// <summary>
        /// 微客身份证号码。加密后的值
        /// </summary>
        [XmlElement("identification")]
        public string Identification { get; set; }

        /// <summary>
        /// 微客手机号码,在没有手机号的情况下，返回99999999999。加密后的值
        /// </summary>
        [XmlElement("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 劳务费,单位元
        /// </summary>
        [XmlElement("service_charge")]
        public string ServiceCharge { get; set; }

        /// <summary>
        /// 任务编号
        /// </summary>
        [XmlElement("task_id")]
        public long TaskId { get; set; }

        /// <summary>
        /// 微客支付宝用户编号
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户任务id
        /// </summary>
        [XmlElement("user_task_id")]
        public string UserTaskId { get; set; }

        /// <summary>
        /// 微客用户编号
        /// </summary>
        [XmlElement("weike_user_id")]
        public long WeikeUserId { get; set; }

        /// <summary>
        /// 微客用户名称，加密后的值
        /// </summary>
        [XmlElement("weike_user_name")]
        public string WeikeUserName { get; set; }
    }
}
