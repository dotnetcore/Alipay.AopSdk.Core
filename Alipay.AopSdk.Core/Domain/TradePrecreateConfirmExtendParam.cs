using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// TradePrecreateConfirmExtendParam Data Structure.
    /// </summary>
    [Serializable]
    public class TradePrecreateConfirmExtendParam : AopObject
    {
        /// <summary>
        /// 发码站点
        /// </summary>
        [XmlElement("precreate_code_from")]
        public string PrecreateCodeFrom { get; set; }
    }
}
