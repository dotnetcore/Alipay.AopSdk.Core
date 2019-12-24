using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// RemoveTagResponse Data Structure.
    /// </summary>
    [Serializable]
    public class RemoveTagResponse : AopObject
    {
        /// <summary>
        /// 批量去标接口结果列表
        /// </summary>
        [XmlArray("remove_tag_result")]
        [XmlArrayItem("remove_tag_result")]
        public List<RemoveTagResult> RemoveTagResult { get; set; }
    }
}
