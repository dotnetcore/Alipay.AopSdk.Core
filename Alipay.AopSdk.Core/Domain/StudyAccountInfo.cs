using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// StudyAccountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class StudyAccountInfo : AopObject
    {
        /// <summary>
        /// 校园卡ID
        /// </summary>
        [XmlElement("alipay_card_no")]
        public string AlipayCardNo { get; set; }

        /// <summary>
        /// 校园卡类型
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 支付宝终身学习账户id
        /// </summary>
        [XmlElement("study_id")]
        public string StudyId { get; set; }
    }
}
