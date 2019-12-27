using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayEcoEprintPrinterAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoEprintPrinterAddModel : AopObject
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
        /// 终端秘钥
        /// </summary>
        [XmlElement("msign")]
        public string Msign { get; set; }

        /// <summary>
        /// 绑定手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 打印机名称
        /// </summary>
        [XmlElement("print_name")]
        public string PrintName { get; set; }
    }
}
