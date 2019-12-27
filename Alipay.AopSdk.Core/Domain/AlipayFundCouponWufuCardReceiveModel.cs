using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayFundCouponWufuCardReceiveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundCouponWufuCardReceiveModel : AopObject
    {
        /// <summary>
        /// 业务流水号，用于数据关联核对，不做为幂等使用。
        /// </summary>
        [XmlElement("front_biz_no")]
        public string FrontBizNo { get; set; }

        /// <summary>
        /// 福卡领取场景
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
