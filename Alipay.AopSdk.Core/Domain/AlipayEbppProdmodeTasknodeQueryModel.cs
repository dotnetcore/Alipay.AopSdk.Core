using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayEbppProdmodeTasknodeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppProdmodeTasknodeQueryModel : AopObject
    {
        /// <summary>
        /// 任务编号
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
