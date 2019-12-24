using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// UpdateCodeResponse Data Structure.
    /// </summary>
    [Serializable]
    public class UpdateCodeResponse : AopObject
    {
        /// <summary>
        /// 批量更新码值返回结果列表
        /// </summary>
        [XmlArray("update_code_result")]
        [XmlArrayItem("update_code_result")]
        public List<UpdateCodeResult> UpdateCodeResult { get; set; }
    }
}
