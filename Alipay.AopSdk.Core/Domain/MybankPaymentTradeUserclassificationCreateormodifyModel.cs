using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MybankPaymentTradeUserclassificationCreateormodifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankPaymentTradeUserclassificationCreateormodifyModel : AopObject
    {
        /// <summary>
        /// 用户分类类别
        /// </summary>
        [XmlElement("classification_name")]
        public string ClassificationName { get; set; }

        /// <summary>
        /// 客户分类打标值,1:准入;0:取消
        /// </summary>
        [XmlElement("classification_value")]
        public string ClassificationValue { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
