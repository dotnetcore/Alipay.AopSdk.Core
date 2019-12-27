using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// KoubeiAdvertDeliveryDiscountQueryResponse.
    /// </summary>
    public class KoubeiAdvertDeliveryDiscountQueryResponse : AopResponse
    {
        /// <summary>
        /// 广告投放出去的优惠信息
        /// </summary>
        [XmlElement("discount")]
        public DiscountInfo Discount { get; set; }
    }
}
