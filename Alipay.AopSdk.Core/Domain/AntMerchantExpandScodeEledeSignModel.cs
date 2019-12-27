using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AntMerchantExpandScodeEledeSignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandScodeEledeSignModel : AopObject
    {
        /// <summary>
        /// 打标请求参数
        /// </summary>
        [XmlArray("add_tag_request")]
        [XmlArrayItem("add_tag_request")]
        public List<AddTagRequest> AddTagRequest { get; set; }
    }
}
