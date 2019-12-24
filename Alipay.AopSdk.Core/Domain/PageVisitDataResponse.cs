using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// PageVisitDataResponse Data Structure.
    /// </summary>
    [Serializable]
    public class PageVisitDataResponse : AopObject
    {
        /// <summary>
        /// 页面的访问次数
        /// </summary>
        [XmlElement("page_pv")]
        public long PagePv { get; set; }

        /// <summary>
        /// 页面的访问人数
        /// </summary>
        [XmlElement("page_uv")]
        public long PageUv { get; set; }

        /// <summary>
        /// 小程序的页面地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
