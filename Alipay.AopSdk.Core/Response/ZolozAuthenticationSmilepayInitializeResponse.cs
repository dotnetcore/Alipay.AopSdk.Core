using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// ZolozAuthenticationSmilepayInitializeResponse.
    /// </summary>
    public class ZolozAuthenticationSmilepayInitializeResponse : AopResponse
    {
        /// <summary>
        /// 返回详细码
        /// </summary>
        [XmlElement("ret_code_sub")]
        public string RetCodeSub { get; set; }

        /// <summary>
        /// 返回详细信息
        /// </summary>
        [XmlElement("ret_message_sub")]
        public string RetMessageSub { get; set; }

        /// <summary>
        /// ZIM上下文ID
        /// </summary>
        [XmlElement("zim_id")]
        public string ZimId { get; set; }

        /// <summary>
        /// 客户端协议
        /// </summary>
        [XmlElement("zim_init_client_data")]
        public string ZimInitClientData { get; set; }
    }
}
