using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// Addresscomponent Data Structure.
    /// </summary>
    [Serializable]
    public class Addresscomponent : AopObject
    {
        /// <summary>
        /// 行政区编码
        /// </summary>
        [XmlElement("adcode")]
        public string Adcode { get; set; }

        /// <summary>
        /// 建筑信息
        /// </summary>
        [XmlElement("building")]
        public Building Building { get; set; }

        /// <summary>
        /// 商圈信息列表
        /// </summary>
        [XmlArray("business_areas")]
        [XmlArrayItem("businessarea")]
        public List<Businessarea> BusinessAreas { get; set; }

        /// <summary>
        /// 当所在城市为北京、上海、天津、重庆四个直辖市时，该字段返回为空。当所在城市属于县级市的时候，此字段为空。
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("citycode")]
        public string Citycode { get; set; }

        /// <summary>
        /// 国内默认返回中国
        /// </summary>
        [XmlElement("country")]
        public string Country { get; set; }

        /// <summary>
        /// 坐标点所在区
        /// </summary>
        [XmlElement("district")]
        public string District { get; set; }

        /// <summary>
        /// 社区信息
        /// </summary>
        [XmlElement("neighborhood")]
        public Neighborhood Neighborhood { get; set; }

        /// <summary>
        /// 坐标点所在省名称
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 门牌信息
        /// </summary>
        [XmlElement("street_number")]
        public Streetnumber StreetNumber { get; set; }

        /// <summary>
        /// 乡镇街道编码
        /// </summary>
        [XmlElement("towncode")]
        public string Towncode { get; set; }

        /// <summary>
        /// 坐标点所在乡镇/街道（此街道为社区街道，不是道路信息）
        /// </summary>
        [XmlElement("township")]
        public string Township { get; set; }
    }
}
