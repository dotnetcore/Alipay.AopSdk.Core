using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ChildCertInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ChildCertInfo : AopObject
    {
        /// <summary>
        /// 儿童业务id
        /// </summary>
        [XmlElement("child_id")]
        public string ChildId { get; set; }

        /// <summary>
        /// 小宝账户跳转链接
        /// </summary>
        [XmlElement("url")]
        public NextUrl Url { get; set; }
    }
}
