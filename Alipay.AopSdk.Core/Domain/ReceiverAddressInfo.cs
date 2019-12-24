using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ReceiverAddressInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ReceiverAddressInfo : AopObject
    {
        /// <summary>
        /// 收货地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 中国标准城市区域码
        /// </summary>
        [XmlElement("division_code")]
        public string DivisionCode { get; set; }

        /// <summary>
        /// 收货人手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 收货人的姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 收货地址邮编
        /// </summary>
        [XmlElement("zip")]
        public string Zip { get; set; }
    }
}
