using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AntMerchantExpandScodeModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandScodeModifyModel : AopObject
    {
        /// <summary>
        /// 批量申请修改吗接口
        /// </summary>
        [XmlArray("update_code_request")]
        [XmlArrayItem("update_code_request")]
        public List<UpdateCodeRequest> UpdateCodeRequest { get; set; }
    }
}
