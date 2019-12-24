using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingBusinessModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarParkingBusinessModifyModel : AopObject
    {
        /// <summary>
        /// 停车场无感业务归属appid。appid在停车平台配置过ISV信息。
        /// </summary>
        [XmlElement("agreement_appid")]
        public string AgreementAppid { get; set; }

        /// <summary>
        /// 支付宝返回停车场id
        /// </summary>
        [XmlElement("parking_id")]
        public string ParkingId { get; set; }
    }
}
