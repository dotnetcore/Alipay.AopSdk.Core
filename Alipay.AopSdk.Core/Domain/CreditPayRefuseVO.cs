using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// CreditPayRefuseVO Data Structure.
    /// </summary>
    [Serializable]
    public class CreditPayRefuseVO : AopObject
    {
        /// <summary>
        /// 拒绝码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 拒绝详情
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }
    }
}
