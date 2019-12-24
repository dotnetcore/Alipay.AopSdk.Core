using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayCommerceIotOrderPrintSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotOrderPrintSyncModel : AopObject
    {
        /// <summary>
        /// 设备唯一标识，设备id
        /// </summary>
        [XmlElement("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// 需要打印的订单数据
        /// </summary>
        [XmlElement("print_data")]
        public string PrintData { get; set; }
    }
}
