using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayBusinessOrderPayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBusinessOrderPayModel : AopObject
    {
        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 支付工具请求列表。支持将现金、商户预付卡、POS、支付宝等支付工具一起支付。
        /// </summary>
        [XmlArray("paytool_list")]
        [XmlArrayItem("paytool_request_detail")]
        public List<PaytoolRequestDetail> PaytoolList { get; set; }
    }
}
