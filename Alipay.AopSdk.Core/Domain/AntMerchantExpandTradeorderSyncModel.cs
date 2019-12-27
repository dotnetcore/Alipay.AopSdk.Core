using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AntMerchantExpandTradeorderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandTradeorderSyncModel : AopObject
    {
        /// <summary>
        /// 订单金额（单位：分）
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 买家的支付宝账号对应的支付宝唯一用户号（以2088开头的纯16位数字）
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 扩展信息（键值对列表，有重复的键后者覆盖前者，建议唯一，以免出现不可预期的结果）
        /// </summary>
        [XmlArray("ext_info")]
        [XmlArrayItem("order_ext_info")]
        public List<OrderExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 商品订单列表
        /// </summary>
        [XmlArray("item_order_list")]
        [XmlArrayItem("item_order")]
        public List<ItemOrder> ItemOrderList { get; set; }

        /// <summary>
        /// 备注信息，一万个字符以内
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 商家补贴金额（单位：分）
        /// </summary>
        [XmlElement("merchant_subsidy_amount")]
        public long MerchantSubsidyAmount { get; set; }

        /// <summary>
        /// 服务商、平台商侧自己的业务订单单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 外部业务类型，由大写字母以及下划线组成，由支付宝分配
        /// </summary>
        [XmlElement("out_biz_type")]
        public string OutBizType { get; set; }

        /// <summary>
        /// 外部商户优惠信息列表
        /// </summary>
        [XmlArray("out_discount_infos")]
        [XmlArrayItem("out_discount_info")]
        public List<OutDiscountInfo> OutDiscountInfos { get; set; }

        /// <summary>
        /// 服务商、平台商在支付宝侧的商户id
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 平台补贴金额（单位：分）
        /// </summary>
        [XmlElement("partner_subsidy_amount")]
        public long PartnerSubsidyAmount { get; set; }

        /// <summary>
        /// 实付金额（单位：分）
        /// </summary>
        [XmlElement("real_amount")]
        public long RealAmount { get; set; }

        /// <summary>
        /// 卖家的支付宝账号对应的支付宝唯一用户号（以2088开头的纯16位数字）
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 蚂蚁门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 订单交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
