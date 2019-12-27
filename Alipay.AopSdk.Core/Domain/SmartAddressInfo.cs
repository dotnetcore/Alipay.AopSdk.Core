using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// SmartAddressInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SmartAddressInfo : AopObject
    {
        /// <summary>
        /// 行政区代码-区，使用蚂蚁标准行政区划代码，可参考  https://render.alipay.com/p/f/fd-jp40xpc9/index.html
        /// </summary>
        [XmlElement("area_code")]
        public long AreaCode { get; set; }

        /// <summary>
        /// 行政区代码-市，使用蚂蚁标准行政区划代码，可参考  https://render.alipay.com/p/f/fd-jp40xpc9/index.html
        /// </summary>
        [XmlElement("city_code")]
        public long CityCode { get; set; }

        /// <summary>
        /// 自助售货机地址
        /// </summary>
        [XmlElement("machine_address")]
        public string MachineAddress { get; set; }

        /// <summary>
        /// 行政区代码-省，使用蚂蚁标准行政区划代码，可参考  https://render.alipay.com/p/f/fd-jp40xpc9/index.html
        /// </summary>
        [XmlElement("province_code")]
        public long ProvinceCode { get; set; }
    }
}
