using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenMiniPoiQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniPoiQueryModel : AopObject
    {
        /// <summary>
        /// 页码，起始页码为1
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 分页大小，默认为10
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }
    }
}
