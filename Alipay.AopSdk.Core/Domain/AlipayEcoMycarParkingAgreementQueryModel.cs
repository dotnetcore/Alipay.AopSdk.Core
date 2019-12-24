using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingAgreementQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarParkingAgreementQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 车牌，用户车辆进场时ISV设备识别到的车辆牌照
        /// </summary>
        [XmlElement("car_number")]
        public string CarNumber { get; set; }

        /// <summary>
        /// 接口版本号，不填则默认为v2.0，建议使用最新版v2.1
        /// </summary>
        [XmlElement("ver")]
        public string Ver { get; set; }
    }
}
