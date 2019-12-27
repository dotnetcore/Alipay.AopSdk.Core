using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// PropertyAuthInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PropertyAuthInfo : AopObject
    {
        /// <summary>
        /// 小区所在区县
        /// </summary>
        [XmlElement("area")]
        public string Area { get; set; }

        /// <summary>
        /// 小区所在城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 小区名称
        /// </summary>
        [XmlElement("community")]
        public string Community { get; set; }

        /// <summary>
        /// 认证信息ID（ISV提供，作为修改、删除唯一标识）
        /// </summary>
        [XmlElement("data_id")]
        public string DataId { get; set; }

        /// <summary>
        /// 小区纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 小区经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 物业公司
        /// </summary>
        [XmlElement("property")]
        public string Property { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
