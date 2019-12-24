using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayEcoAcceptanceRequestCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoAcceptanceRequestCreateModel : AopObject
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("accetor_id")]
        public string AccetorId { get; set; }

        /// <summary>
        /// 用户名字、称呼等
        /// </summary>
        [XmlElement("accetor_nick")]
        public string AccetorNick { get; set; }

        /// <summary>
        /// 用户类型，淘宝账户
        /// </summary>
        [XmlElement("accetor_user_type")]
        public string AccetorUserType { get; set; }

        /// <summary>
        /// 用例ID
        /// </summary>
        [XmlElement("case_id")]
        public string CaseId { get; set; }

        /// <summary>
        /// 用例需要的参数，可以采用这种结构
        /// </summary>
        [XmlElement("params")]
        public string Params { get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
