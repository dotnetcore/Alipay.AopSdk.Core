using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// NearMallBo Data Structure.
    /// </summary>
    [Serializable]
    public class NearMallBo : AopObject
    {
        /// <summary>
        /// json字符串表示额外信息
        /// </summary>
        [XmlElement("attribute")]
        public string Attribute { get; set; }

        /// <summary>
        /// 距离
        /// </summary>
        [XmlElement("distance")]
        public string Distance { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 商圈id
        /// </summary>
        [XmlElement("mall_id")]
        public string MallId { get; set; }

        /// <summary>
        /// 商圈图片
        /// </summary>
        [XmlElement("mall_logo")]
        public string MallLogo { get; set; }

        /// <summary>
        /// 商圈名字
        /// </summary>
        [XmlElement("mall_name")]
        public string MallName { get; set; }
    }
}
