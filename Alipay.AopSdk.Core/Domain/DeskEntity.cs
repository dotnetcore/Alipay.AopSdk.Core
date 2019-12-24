using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// DeskEntity Data Structure.
    /// </summary>
    [Serializable]
    public class DeskEntity : AopObject
    {
        /// <summary>
        /// 餐区ID
        /// </summary>
        [XmlElement("area_id")]
        public string AreaId { get; set; }

        /// <summary>
        /// 餐桌名称
        /// </summary>
        [XmlElement("desk_name")]
        public string DeskName { get; set; }

        /// <summary>
        /// 桌位编码
        /// </summary>
        [XmlElement("desk_no")]
        public string DeskNo { get; set; }

        /// <summary>
        /// 桌台ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 桌位人数
        /// </summary>
        [XmlElement("max_num")]
        public long MaxNum { get; set; }

        /// <summary>
        /// 二维码id
        /// </summary>
        [XmlElement("qr_code_id")]
        public string QrCodeId { get; set; }

        /// <summary>
        /// 餐桌二维码关系ID
        /// </summary>
        [XmlElement("relation_id")]
        public string RelationId { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 桌位排序
        /// </summary>
        [XmlElement("sort_num")]
        public long SortNum { get; set; }
    }
}
