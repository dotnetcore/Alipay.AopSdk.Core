using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// CommerceAppUploadResponseData Data Structure.
    /// </summary>
    [Serializable]
    public class CommerceAppUploadResponseData : AopObject
    {
        /// <summary>
        /// 返回主体中具体内容
        /// </summary>
        [XmlElement("response")]
        public string Response { get; set; }

        /// <summary>
        /// 系统时间
        /// </summary>
        [XmlElement("time")]
        public long Time { get; set; }
    }
}
