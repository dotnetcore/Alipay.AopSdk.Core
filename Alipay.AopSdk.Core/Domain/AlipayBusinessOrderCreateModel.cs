using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayBusinessOrderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBusinessOrderCreateModel : AopObject
    {
        /// <summary>
        /// 买家身份信息。注：本接口只支持传入type为USER_ID，issuer为ALIPAY
        /// </summary>
        [XmlElement("buyer_identity")]
        public UserIdentity BuyerIdentity { get; set; }

        /// <summary>
        /// 订单控制信息，比如超时信息。
        /// </summary>
        [XmlElement("control_info")]
        public ControlInfo ControlInfo { get; set; }

        /// <summary>
        /// 订单经营环境信息
        /// </summary>
        [XmlElement("env_info")]
        public EnvInfo EnvInfo { get; set; }

        /// <summary>
        /// 订单商品列表
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("item_detail")]
        public List<ItemDetail> ItemList { get; set; }

        /// <summary>
        /// 商户外部订单号
        /// </summary>
        [XmlElement("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 订单金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 订单创建指定营销信息，如果不传入该字段，表明不咨询前置营销
        /// </summary>
        [XmlElement("selected_marketing")]
        public MarketingSelectionInfo SelectedMarketing { get; set; }

        /// <summary>
        /// 卖家身份信息。注：只支持传入type为USER_ID，issuer为ALIPAY
        /// </summary>
        [XmlElement("seller_identity")]
        public UserIdentity SellerIdentity { get; set; }

        /// <summary>
        /// 订单标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
