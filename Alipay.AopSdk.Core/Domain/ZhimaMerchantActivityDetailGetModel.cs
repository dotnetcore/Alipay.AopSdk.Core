using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ZhimaMerchantActivityDetailGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaMerchantActivityDetailGetModel : AopObject
    {
        /// <summary>
        /// 活动号，唯一标识一个活动。
        /// </summary>
        [XmlElement("activity_no")]
        public string ActivityNo { get; set; }

        /// <summary>
        /// 用户取消合约后，有行动点可以回跳到该地址
        /// </summary>
        [XmlElement("canceled_callback")]
        public string CanceledCallback { get; set; }

        /// <summary>
        /// 活动所属门店。线上模式等没有门店概念的活动可不填
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 签约成功页回跳，本页面接口拉起活动页，用户签约后，成功页可以回跳到业务发起者的页面。
        /// </summary>
        [XmlElement("sign_success_callback")]
        public string SignSuccessCallback { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
