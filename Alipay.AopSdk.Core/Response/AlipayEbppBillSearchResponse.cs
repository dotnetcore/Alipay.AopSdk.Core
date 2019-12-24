using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayEbppBillSearchResponse.
    /// </summary>
    public class AlipayEbppBillSearchResponse : AopResponse
    {
        /// <summary>
        /// 已经缓存的的key
        /// </summary>
        [XmlElement("cachekey")]
        public string Cachekey { get; set; }

        /// <summary>
        /// 实时查询欠费单返回对象
        /// </summary>
        [XmlArray("inst_bill_info_list")]
        [XmlArrayItem("query_inst_bill_info")]
        public List<QueryInstBillInfo> InstBillInfoList { get; set; }
    }
}
