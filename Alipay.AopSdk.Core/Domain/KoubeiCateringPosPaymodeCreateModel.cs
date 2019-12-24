using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiCateringPosPaymodeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosPaymodeCreateModel : AopObject
    {
        /// <summary>
        /// 固定面额
        /// </summary>
        [XmlElement("fixed_amount")]
        public string FixedAmount { get; set; }

        /// <summary>
        /// 是否固定面额（false:否；true:是）
        /// </summary>
        [XmlElement("fixed_switch")]
        public bool FixedSwitch { get; set; }

        /// <summary>
        /// 计入实收比例
        /// </summary>
        [XmlElement("income_ratio")]
        public string IncomeRatio { get; set; }

        /// <summary>
        /// 支付方式名称
        /// </summary>
        [XmlElement("pay_name")]
        public string PayName { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
