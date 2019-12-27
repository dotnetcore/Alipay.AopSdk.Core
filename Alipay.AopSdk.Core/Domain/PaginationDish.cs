using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// PaginationDish Data Structure.
    /// </summary>
    [Serializable]
    public class PaginationDish : AopObject
    {
        /// <summary>
        /// 出参列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("kbdish_info")]
        public List<KbdishInfo> List { get; set; }

        /// <summary>
        /// 表示当前页数
        /// </summary>
        [XmlElement("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 表示每页条数
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("total_count")]
        public string TotalCount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_page")]
        public string TotalPage { get; set; }
    }
}
