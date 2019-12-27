using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MybankCreditSupplychainArUnsignModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSupplychainArUnsignModel : AopObject
    {
        /// <summary>
        /// 协议产品码
        /// </summary>
        [XmlElement("ar_pd_code")]
        public string ArPdCode { get; set; }

        /// <summary>
        /// 请求幂等控制ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 合约编号
        /// </summary>
        [XmlElement("seller_ar_no")]
        public string SellerArNo { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 站点，目前只支持ALIPAY
        /// </summary>
        [XmlElement("site")]
        public string Site { get; set; }

        /// <summary>
        /// 站点ID
        /// </summary>
        [XmlElement("site_user_id")]
        public string SiteUserId { get; set; }

        /// <summary>
        /// 场景来源
        /// </summary>
        [XmlElement("trade_source")]
        public string TradeSource { get; set; }
    }
}
