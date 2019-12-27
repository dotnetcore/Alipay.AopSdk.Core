using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// KoubeiItemExtitemCategoryQueryResponse.
    /// </summary>
    public class KoubeiItemExtitemCategoryQueryResponse : AopResponse
    {
        /// <summary>
        /// 品类信息列表
        /// </summary>
        [XmlArray("category_list")]
        [XmlArrayItem("ext_category")]
        public List<ExtCategory> CategoryList { get; set; }
    }
}
