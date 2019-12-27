using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayInsSceneProductAgreementQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneProductAgreementQueryModel : AopObject
    {
        /// <summary>
        /// 签约协议类型，参见InsSignTypeEnum
        /// </summary>
        [XmlElement("agreement_sign_type")]
        public string AgreementSignType { get; set; }

        /// <summary>
        /// 支付宝2088开头的签约商户的用户id
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 签约渠道，有系统分配给用户
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 商户协议有效时间查询的最大时间，格式为yyyy-MM-dd hh:mm:ss
        /// </summary>
        [XmlElement("end_effect_time")]
        public string EndEffectTime { get; set; }

        /// <summary>
        /// 产品机构编码
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 签约用户id，与sign_user_type匹配
        /// </summary>
        [XmlElement("sign_user_id")]
        public string SignUserId { get; set; }

        /// <summary>
        /// 签约用户类型，详见SignUserTypeEnum
        /// </summary>
        [XmlElement("sign_user_type")]
        public string SignUserType { get; set; }

        /// <summary>
        /// 查询的有效期范围的开始时间条件
        /// </summary>
        [XmlElement("start_effect_time")]
        public string StartEffectTime { get; set; }

        /// <summary>
        /// 状态枚举详见InsAgreementStatusEnum
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }
    }
}
