using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiCateringPosParamModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosParamModifyModel : AopObject
    {
        /// <summary>
        /// 账单金额位数
        /// </summary>
        [XmlElement("carry_rule")]
        public string CarryRule { get; set; }

        /// <summary>
        /// 就餐模式（ takeMeal：取餐模式（默认）； foodDelivery：送餐模式 ）
        /// </summary>
        [XmlElement("dining_mode")]
        public string DiningMode { get; set; }

        /// <summary>
        /// 是否开通饿了么（false：否；true：是）
        /// </summary>
        [XmlElement("open_ele")]
        public bool OpenEle { get; set; }

        /// <summary>
        /// 异常操作原因（false：否；true：是）
        /// </summary>
        [XmlElement("reason_flag")]
        public bool ReasonFlag { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 是否有桌台（false:否；true:是）
        /// </summary>
        [XmlElement("table_flag")]
        public bool TableFlag { get; set; }

        /// <summary>
        /// 金额尾数规则（  yuan：元；  horn：角；  cent：分（默认）  ）
        /// </summary>
        [XmlElement("tail_number_rule")]
        public string TailNumberRule { get; set; }

        /// <summary>
        /// 外卖是否自动接单（false：否；true：是）
        /// </summary>
        [XmlElement("takeout_auto_receipt")]
        public bool TakeoutAutoReceipt { get; set; }
    }
}
