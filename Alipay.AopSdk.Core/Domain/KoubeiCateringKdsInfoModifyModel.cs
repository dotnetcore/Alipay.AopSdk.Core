using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiCateringKdsInfoModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringKdsInfoModifyModel : AopObject
    {
        /// <summary>
        /// kds配置详情
        /// </summary>
        [XmlArray("kds_info_model_list")]
        [XmlArrayItem("kds_info_model")]
        public List<KdsInfoModel> KdsInfoModelList { get; set; }
    }
}
