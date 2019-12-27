using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayEcoAcceptanceTaskCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoAcceptanceTaskCreateModel : AopObject
    {
        /// <summary>
        /// 验收任务需要验收的用例
        /// </summary>
        [XmlArray("case_list")]
        [XmlArrayItem("test_case_param")]
        public List<TestCaseParam> CaseList { get; set; }

        /// <summary>
        /// TMALL_NEWRETAIL 调用方需要申请自己调用来源，以便于做一些逻辑管控
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 商家ID、机构ID，支付宝域即商户PID；淘宝域应该是SELLERID之类
        /// </summary>
        [XmlElement("company_id")]
        public string CompanyId { get; set; }

        /// <summary>
        /// 公司、机构、商家等名称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 创建人USERID
        /// </summary>
        [XmlElement("creator_id")]
        public string CreatorId { get; set; }

        /// <summary>
        /// 创建人姓名
        /// </summary>
        [XmlElement("creator_nick")]
        public string CreatorNick { get; set; }

        /// <summary>
        /// 用户账号类型
        /// </summary>
        [XmlElement("creator_user_type")]
        public string CreatorUserType { get; set; }

        /// <summary>
        /// TIANSUOB表示 天猫新零售；BUS 表示公交行业
        /// </summary>
        [XmlElement("industry")]
        public string Industry { get; set; }

        /// <summary>
        /// 用于双向数据关联，外部ID
        /// </summary>
        [XmlElement("out_id")]
        public string OutId { get; set; }

        /// <summary>
        /// 一段简要的验收描述
        /// </summary>
        [XmlElement("topic")]
        public string Topic { get; set; }
    }
}
