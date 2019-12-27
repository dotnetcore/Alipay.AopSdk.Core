using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayEbppOrderItemQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppOrderItemQueryModel : AopObject
    {
        /// <summary>
        /// 机构端订单项id列表
        /// </summary>
        [XmlElement("inst_item_id")]
        public string InstItemId { get; set; }
    }
}
