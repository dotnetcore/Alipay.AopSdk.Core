using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// PageInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PageInfo : AopObject
    {
        /// <summary>
        /// 分页查询当前页
        /// </summary>
        [XmlElement("current")]
        public long Current { get; set; }

        /// <summary>
        /// 分页查询单页记录数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 创意总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
