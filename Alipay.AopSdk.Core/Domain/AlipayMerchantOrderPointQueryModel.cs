using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayMerchantOrderPointQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantOrderPointQueryModel : AopObject
    {
        /// <summary>
        /// 需要查询的积分类型，如家庭积分、会员积分、返佣积分等等
        /// </summary>
        [XmlElement("point_type")]
        public string PointType { get; set; }

        /// <summary>
        /// 用户身份
        /// </summary>
        [XmlElement("user")]
        public UserIdentity User { get; set; }
    }
}
