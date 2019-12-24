using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayUserCustomertagSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserCustomertagSaveModel : AopObject
    {
        /// <summary>
        /// 业务场景码。由支付宝产品经理分配，相当于存储标签的使用凭证。
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 标签名字
        /// </summary>
        [XmlElement("tag_name")]
        public string TagName { get; set; }

        /// <summary>
        /// 标签值，常见为T,F
        /// </summary>
        [XmlElement("tag_value")]
        public string TagValue { get; set; }

        /// <summary>
        /// 支付宝会员uid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
