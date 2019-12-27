using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayEcoEprintTaskSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoEprintTaskSubmitModel : AopObject
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
        /// 打印内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

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
        /// 业务内部编号
        /// </summary>
        [XmlElement("origin_id")]
        public string OriginId { get; set; }
    }
}
