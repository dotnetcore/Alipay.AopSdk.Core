using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayOpenMiniCategoryQueryResponse.
    /// </summary>
    public class AlipayOpenMiniCategoryQueryResponse : AopResponse
    {
        /// <summary>
        /// 小程序类目列表
        /// </summary>
        [XmlArray("category_list")]
        [XmlArrayItem("mini_app_category")]
        public List<MiniAppCategory> CategoryList { get; set; }
    }
}
