using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayEcoPrinterStatusNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoPrinterStatusNotifyModel : AopObject
    {
        /// <summary>
        /// 签名
        /// </summary>
        [XmlElement("eprint_sign")]
        public string EprintSign { get; set; }

        /// <summary>
        /// 终端号
        /// </summary>
        [XmlElement("machine_code")]
        public string MachineCode { get; set; }

        /// <summary>
        /// 授权类型：0=自有应用授权；1=开放应用授权
        /// </summary>
        [XmlElement("oauth_type")]
        public long OauthType { get; set; }

        /// <summary>
        /// 打印机终端状态 1=在线 2=缺纸 0=离线
        /// </summary>
        [XmlElement("online")]
        public long Online { get; set; }

        /// <summary>
        /// 回调时间
        /// </summary>
        [XmlElement("push_time")]
        public string PushTime { get; set; }
    }
}
