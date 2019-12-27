using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MallUserVerify Data Structure.
    /// </summary>
    [Serializable]
    public class MallUserVerify : AopObject
    {
        /// <summary>
        /// 核销状态：UNUSE：未核销，USE：已经核销，CLOSE：关闭
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 核销码类型，包括：SCENE_ORDER(场景订单)
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户订单核销码
        /// </summary>
        [XmlElement("verify_code")]
        public string VerifyCode { get; set; }
    }
}
