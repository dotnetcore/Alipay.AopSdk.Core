using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// IcrowdUseResp Data Structure.
    /// </summary>
    [Serializable]
    public class IcrowdUseResp : AopObject
    {
        /// <summary>
        /// 方法ID
        /// </summary>
        [XmlElement("method_id")]
        public string MethodId { get; set; }

        /// <summary>
        /// 方法返回结果
        /// </summary>
        [XmlElement("ret_val")]
        public string RetVal { get; set; }
    }
}
