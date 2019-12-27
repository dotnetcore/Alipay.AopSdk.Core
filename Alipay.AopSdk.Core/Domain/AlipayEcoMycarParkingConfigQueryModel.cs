using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingConfigQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarParkingConfigQueryModel : AopObject
    {
        /// <summary>
        /// H5传入参数固定值：alipay.eco.mycar.parking.userpage.query    小程序传入参数固定值：alipay.eco.mycar.parking.isv.homepage
        /// </summary>
        [XmlElement("interface_name")]
        public string InterfaceName { get; set; }

        /// <summary>
        /// 传入参数固定值:interface_page
        /// </summary>
        [XmlElement("interface_type")]
        public string InterfaceType { get; set; }
    }
}
