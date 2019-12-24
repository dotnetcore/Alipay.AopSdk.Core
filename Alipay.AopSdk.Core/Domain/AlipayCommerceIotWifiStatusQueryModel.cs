using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayCommerceIotWifiStatusQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotWifiStatusQueryModel : AopObject
    {
        /// <summary>
        /// 设备唯一id
        /// </summary>
        [XmlElement("biz_tid")]
        public string BizTid { get; set; }
    }
}
