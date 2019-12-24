using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// TestCaseParam Data Structure.
    /// </summary>
    [Serializable]
    public class TestCaseParam : AopObject
    {
        /// <summary>
        /// 测试用例ID或者编码
        /// </summary>
        [XmlElement("case_id")]
        public string CaseId { get; set; }

        /// <summary>
        /// 测试用例类型
        /// </summary>
        [XmlElement("case_type")]
        public string CaseType { get; set; }

        /// <summary>
        /// 用例集ID
        /// </summary>
        [XmlElement("test_suite_id")]
        public string TestSuiteId { get; set; }

        /// <summary>
        /// 用例集名称
        /// </summary>
        [XmlElement("test_suite_name")]
        public string TestSuiteName { get; set; }
    }
}
