using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AntMerchantExpandDeliveryGoodsinfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandDeliveryGoodsinfoSyncModel : AopObject
    {
        /// <summary>
        /// 配送指令ID
        /// </summary>
        [XmlElement("assign_item_id")]
        public string AssignItemId { get; set; }

        /// <summary>
        /// 扩展信息，map的json String
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        [XmlElement("logistics_no")]
        public string LogisticsNo { get; set; }

        /// <summary>
        /// 发货标签，全局唯一
        /// </summary>
        [XmlElement("send_goods_tag")]
        public string SendGoodsTag { get; set; }

        /// <summary>
        /// 标签类型
        /// </summary>
        [XmlElement("tag_type")]
        public string TagType { get; set; }
    }
}
