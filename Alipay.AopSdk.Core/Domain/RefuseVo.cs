using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// RefuseVo Data Structure.
    /// </summary>
    [Serializable]
    public class RefuseVo : AopObject
    {
        /// <summary>
        /// 拒绝码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 拒绝信息
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }
    }
}
