using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayEcoEprintOrderCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoEprintOrderCancelModel : AopObject
    {
        /// <summary>
        /// 应用ID
        /// </summary>
        [XmlElement("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// 应用Secret
        /// </summary>
        [XmlElement("client_secret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// 应用访问凭证
        /// </summary>
        [XmlElement("eprint_token")]
        public string EprintToken { get; set; }

        /// <summary>
        /// 终端号
        /// </summary>
        [XmlElement("machine_code")]
        public string MachineCode { get; set; }

        /// <summary>
        /// 待取消订单Id，云平台端订单Id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
