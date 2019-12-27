using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// VulList Data Structure.
    /// </summary>
    [Serializable]
    public class VulList : AopObject
    {
        /// <summary>
        /// 漏洞奖励
        /// </summary>
        [XmlElement("coin")]
        public long Coin { get; set; }

        /// <summary>
        /// 漏洞等级
        /// </summary>
        [XmlElement("level")]
        public long Level { get; set; }

        /// <summary>
        /// 漏洞信息标题
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 漏洞提交修复状态
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 漏洞提交时间
        /// </summary>
        [XmlElement("submit_time")]
        public string SubmitTime { get; set; }

        /// <summary>
        /// 漏洞id
        /// </summary>
        [XmlElement("vul_id")]
        public long VulId { get; set; }
    }
}
