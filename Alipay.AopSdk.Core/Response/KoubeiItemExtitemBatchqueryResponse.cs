using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// KoubeiItemExtitemBatchqueryResponse.
    /// </summary>
    public class KoubeiItemExtitemBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 商品信息列表
        /// </summary>
        [XmlArray("model_list")]
        [XmlArrayItem("ext_item")]
        public List<ExtItem> ModelList { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_size")]
        public string TotalSize { get; set; }
    }
}
