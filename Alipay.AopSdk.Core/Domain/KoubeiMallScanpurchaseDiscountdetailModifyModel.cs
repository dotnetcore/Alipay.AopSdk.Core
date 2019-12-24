using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiMallScanpurchaseDiscountdetailModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMallScanpurchaseDiscountdetailModifyModel : AopObject
    {
        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("buyer_user_id")]
        public string BuyerUserId { get; set; }

        /// <summary>
        /// 优惠信息列表
        /// </summary>
        [XmlArray("discount_details")]
        [XmlArrayItem("mall_discount_detail")]
        public List<MallDiscountDetail> DiscountDetails { get; set; }

        /// <summary>
        /// 商圈场景订单id。（order_id和trade_no不能都为空）
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 支付宝交易号，（order_id和trade_no不能都为空）
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
