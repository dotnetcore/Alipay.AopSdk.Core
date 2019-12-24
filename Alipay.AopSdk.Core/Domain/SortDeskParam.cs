using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// SortDeskParam Data Structure.
    /// </summary>
    [Serializable]
    public class SortDeskParam : AopObject
    {
        /// <summary>
        /// 区域ID
        /// </summary>
        [XmlElement("area_id")]
        public string AreaId { get; set; }

        /// <summary>
        /// 桌位编码
        /// </summary>
        [XmlElement("desk_no")]
        public string DeskNo { get; set; }

        /// <summary>
        /// 桌位ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 排序顺序
        /// </summary>
        [XmlElement("sort")]
        public long Sort { get; set; }
    }
}
