using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiCateringPosDeskCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosDeskCreateModel : AopObject
    {
        /// <summary>
        /// 餐区ID
        /// </summary>
        [XmlElement("area_id")]
        public string AreaId { get; set; }

        /// <summary>
        /// 桌位名称前缀
        /// </summary>
        [XmlElement("desk_name")]
        public string DeskName { get; set; }

        /// <summary>
        /// 桌位最大可坐人数
        /// </summary>
        [XmlElement("max_num")]
        public long MaxNum { get; set; }

        /// <summary>
        /// 批量添加桌位的数量
        /// </summary>
        [XmlElement("num")]
        public long Num { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
