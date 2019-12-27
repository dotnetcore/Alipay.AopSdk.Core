using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenMiniBaseinfoAmapQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniBaseinfoAmapQueryModel : AopObject
    {
        /// <summary>
        /// 小程序应用id
        /// </summary>
        [XmlElement("appid")]
        public string Appid { get; set; }
    }
}
