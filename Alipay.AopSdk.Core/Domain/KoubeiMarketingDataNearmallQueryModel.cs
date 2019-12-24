using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiMarketingDataNearmallQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataNearmallQueryModel : AopObject
    {
        /// <summary>
        /// 说明来源
        /// </summary>
        [XmlElement("app_channel")]
        public string AppChannel { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("city_id")]
        public string CityId { get; set; }

        /// <summary>
        /// 开始标记
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 数量标记
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 设备id
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 设备版本号
        /// </summary>
        [XmlElement("product_version")]
        public string ProductVersion { get; set; }

        /// <summary>
        /// 半径，单位【米】
        /// </summary>
        [XmlElement("radius")]
        public string Radius { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 地理位置经度
        /// </summary>
        [XmlElement("x")]
        public long X { get; set; }

        /// <summary>
        /// 地理位置纬度
        /// </summary>
        [XmlElement("y")]
        public long Y { get; set; }
    }
}
