using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// DeskAreaEntity Data Structure.
    /// </summary>
    [Serializable]
    public class DeskAreaEntity : AopObject
    {
        /// <summary>
        /// 区域Id（新增时无需设值）
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 餐区名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 餐区排序
        /// </summary>
        [XmlElement("sort")]
        public long Sort { get; set; }
    }
}
