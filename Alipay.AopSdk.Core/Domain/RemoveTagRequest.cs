using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// RemoveTagRequest Data Structure.
    /// </summary>
    [Serializable]
    public class RemoveTagRequest : AopObject
    {
        /// <summary>
        /// biz_id，唯一，业务id，用于业务请求的幂等标志
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 去标类型，PID或SMID
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// pid或smid的值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
