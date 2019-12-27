using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// KoubeiTradeTicketTicketcodeQueryResponse.
    /// </summary>
    public class KoubeiTradeTicketTicketcodeQueryResponse : AopResponse
    {
        /// <summary>
        /// 非次卡场景，表示同一订单下同类凭证的可核销份数； 次卡场景，表示可用核销份数。
        /// </summary>
        [XmlElement("available_quantity")]
        public string AvailableQuantity { get; set; }

        /// <summary>
        /// 用户购买时商品的现价
        /// </summary>
        [XmlElement("current_price")]
        public string CurrentPrice { get; set; }

        /// <summary>
        /// 券生效时间
        /// </summary>
        [XmlElement("effect_date")]
        public string EffectDate { get; set; }

        /// <summary>
        /// 券失效时间
        /// </summary>
        [XmlElement("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 凭证对应商品别名，在口碑商品创建时候设置
        /// </summary>
        [XmlElement("item_alias")]
        public string ItemAlias { get; set; }

        /// <summary>
        /// 口碑商品ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 凭证对应的订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 用户购买时商品的原价
        /// </summary>
        [XmlElement("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 12位的券码，券码为纯数字，且唯一不重复
        /// </summary>
        [XmlElement("ticket_code")]
        public string TicketCode { get; set; }

        /// <summary>
        /// 券状态  1.  USED:该券已经被消费,无法核销  2.  EFFECTIVE:未核销，且可以在当前门店核销  3.  UN_EFFECTIVE:未核销，但不可以在当前门店核销  4.  REFUNDED:该券已经退款,无法核销  5.  USING:核销处理中,无法核销  6.  REFUNDING:退款处理中,无法核销
        /// </summary>
        [XmlElement("ticket_status")]
        public string TicketStatus { get; set; }

        /// <summary>
        /// 券状态描述  1.  该券已经被消费，无法核销  2.  未核销，且可以在当前门店核销  3.  未核销，但不可以在当前门店核销  4.  该券已经退款，无法核销  5.  该券正在核销处理中,无法核销  6.  该券正在退款处理中,无法核销
        /// </summary>
        [XmlElement("ticket_status_desc")]
        public string TicketStatusDesc { get; set; }

        /// <summary>
        /// 凭证的流水记录
        /// </summary>
        [XmlArray("ticket_trans_info_list")]
        [XmlArrayItem("ticket_trans_info")]
        public List<TicketTransInfo> TicketTransInfoList { get; set; }

        /// <summary>
        /// 是否次卡。是次卡场景值为true，反之为false
        /// </summary>
        [XmlElement("time_cards")]
        public string TimeCards { get; set; }

        /// <summary>
        /// 非次卡场景，表示同一订单下同类凭证的总份数；次卡场景，表示次卡原始总份数
        /// </summary>
        [XmlElement("total_quantity")]
        public string TotalQuantity { get; set; }

        /// <summary>
        /// 券码对应的凭证资产id
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
