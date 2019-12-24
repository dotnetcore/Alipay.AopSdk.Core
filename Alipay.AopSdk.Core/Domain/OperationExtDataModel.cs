using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// OperationExtDataModel Data Structure.
    /// </summary>
    [Serializable]
    public class OperationExtDataModel : AopObject
    {
        /// <summary>
        /// 奖品金额,单位分
        /// </summary>
        [XmlElement("prize_amount")]
        public string PrizeAmount { get; set; }

        /// <summary>
        /// 奖品 id
        /// </summary>
        [XmlElement("prize_id")]
        public string PrizeId { get; set; }

        /// <summary>
        /// 奖品名称
        /// </summary>
        [XmlElement("prize_name")]
        public string PrizeName { get; set; }

        /// <summary>
        /// 营销错误码
        /// </summary>
        [XmlElement("promo_error_code")]
        public string PromoErrorCode { get; set; }
    }
}
