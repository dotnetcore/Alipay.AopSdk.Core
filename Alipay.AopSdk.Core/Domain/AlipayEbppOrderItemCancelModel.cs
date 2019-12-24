using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayEbppOrderItemCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppOrderItemCancelModel : AopObject
    {
        /// <summary>
        /// 机构订单子项id
        /// </summary>
        [XmlElement("inst_item_id")]
        public string InstItemId { get; set; }
    }
}
