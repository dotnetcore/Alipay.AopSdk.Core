using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// PageCreative Data Structure.
    /// </summary>
    [Serializable]
    public class PageCreative : AopObject
    {
        /// <summary>
        /// 创意详情列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("creative_detail")]
        public List<CreativeDetail> List { get; set; }

        /// <summary>
        /// 创意分页信息
        /// </summary>
        [XmlElement("pagination")]
        public PageInfo Pagination { get; set; }
    }
}
