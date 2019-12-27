using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenMiniPlanOperateBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniPlanOperateBatchqueryModel : AopObject
    {
        /// <summary>
        /// 页码数，从第一页开始
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页记录数，默认10
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 投放方案场景码，目前只支持支付后推荐场景：PAYMENT_SUCCESS
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
