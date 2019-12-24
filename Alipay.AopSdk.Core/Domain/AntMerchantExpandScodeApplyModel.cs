using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AntMerchantExpandScodeApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandScodeApplyModel : AopObject
    {
        /// <summary>
        /// apply_code_request，申请S码的请求参数
        /// </summary>
        [XmlArray("apply_code_request")]
        [XmlArrayItem("apply_code_request")]
        public List<ApplyCodeRequest> ApplyCodeRequest { get; set; }
    }
}
