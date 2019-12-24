using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayUserAliyunbenefitReceiveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAliyunbenefitReceiveModel : AopObject
    {
        /// <summary>
        /// 格式为yyyy-MM-dd HH:mm:ss ，业务操作时间用于对账，不传则以调用请求的当前时间计算
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 阿里云商品Id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 外部业务号码，即调用方的业务流水号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 兑换策略，用于标识当前兑换是纯积分兑换还是积分+钱兑换
        /// </summary>
        [XmlElement("price_strategy")]
        public string PriceStrategy { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 校验的积分数量，此积分数用于在兑换权益时，校验用户页面看到的积分数量和实际扣减时决策的积分数量是否一致，如果不一致，则不允许下单
        /// </summary>
        [XmlElement("verify_point")]
        public long VerifyPoint { get; set; }
    }
}
