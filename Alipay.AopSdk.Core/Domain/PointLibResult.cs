using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// PointLibResult Data Structure.
    /// </summary>
    [Serializable]
    public class PointLibResult : AopObject
    {
        /// <summary>
        /// 仓库剩余积分数
        /// </summary>
        [XmlElement("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 积分库ID
        /// </summary>
        [XmlElement("library_id")]
        public string LibraryId { get; set; }

        /// <summary>
        /// 积分库名称
        /// </summary>
        [XmlElement("library_name")]
        public string LibraryName { get; set; }

        /// <summary>
        /// 积分库状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 仓库积分总数
        /// </summary>
        [XmlElement("sum_point")]
        public string SumPoint { get; set; }
    }
}
