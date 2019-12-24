using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayFinanceQuotationFindataSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinanceQuotationFindataSendModel : AopObject
    {
        /// <summary>
        /// 业务类型。strategy_pool策略池,strategy_pool_detail策略池明细
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 机构发送给蚂蚁的业务数据。仅支持JSON
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }
    }
}
