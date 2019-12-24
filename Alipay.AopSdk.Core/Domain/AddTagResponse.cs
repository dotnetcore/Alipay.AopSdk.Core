using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AddTagResponse Data Structure.
    /// </summary>
    [Serializable]
    public class AddTagResponse : AopObject
    {
        /// <summary>
        /// 批量打标接口返回值
        /// </summary>
        [XmlArray("add_tag_result")]
        [XmlArrayItem("add_tag_result")]
        public List<AddTagResult> AddTagResult { get; set; }
    }
}
