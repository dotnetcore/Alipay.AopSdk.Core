using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayEcoEprintOrderNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoEprintOrderNotifyModel : AopObject
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
        /// 云平台订单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 回调时间
        /// </summary>
        [XmlElement("push_time")]
        public string PushTime { get; set; }

        /// <summary>
        /// 打印状态 -1=打印取消 0=打印命令发送成功 1=打印完成 2=打印异常
        /// </summary>
        [XmlElement("state")]
        public long State { get; set; }
    }
}
