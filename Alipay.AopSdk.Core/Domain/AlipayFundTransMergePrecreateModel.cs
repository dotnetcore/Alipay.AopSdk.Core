using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayFundTransMergePrecreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundTransMergePrecreateModel : AopObject
    {
        /// <summary>
        /// 业务场景。  DINGTALK_MERCHANT_PAY：钉钉企业付款
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 转账请求的扩展参数，具体请与支付宝工程师联系。  merchant_op_id：商户所属的操作员id
        /// </summary>
        [XmlElement("business_params")]
        public string BusinessParams { get; set; }

        /// <summary>
        /// 用于收银台展示标题，必填
        /// </summary>
        [XmlElement("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 付款方信息。如果指定了，在某些场景下以指定的付款方为准，在某些场景下会做一致性校验。
        /// </summary>
        [XmlElement("payer_info")]
        public Participant PayerInfo { get; set; }

        /// <summary>
        /// 合并付款的业务产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 绝对超时时间，格式为yyyy-MM-dd HH:mm。
        /// </summary>
        [XmlElement("time_expire")]
        public string TimeExpire { get; set; }

        /// <summary>
        /// 转账订单列表，最多支持10条。
        /// </summary>
        [XmlArray("trans_order_list")]
        [XmlArrayItem("trans_order_detail")]
        public List<TransOrderDetail> TransOrderList { get; set; }
    }
}
