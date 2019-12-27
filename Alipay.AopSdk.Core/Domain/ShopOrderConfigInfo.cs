using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ShopOrderConfigInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShopOrderConfigInfo : AopObject
    {
        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_infos")]
        public string ExtInfos { get; set; }

        /// <summary>
        /// 店铺营业状态：  可枚举：  (1)OPEN 营业  (2)CLOSE 休息
        /// </summary>
        [XmlElement("order_entry_status")]
        public string OrderEntryStatus { get; set; }

        /// <summary>
        /// 口碑门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 外部门店编号；最长32位字符，该编号将作为收单接口的入参， 请开发者自行确保其唯一性。
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }
    }
}
