using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiCateringPosPaymodeDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosPaymodeDeleteModel : AopObject
    {
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

        /// <summary>
        /// 是否系统（false:否；true:是）
        /// </summary>
        [XmlElement("system")]
        public bool System { get; set; }
    }
}
