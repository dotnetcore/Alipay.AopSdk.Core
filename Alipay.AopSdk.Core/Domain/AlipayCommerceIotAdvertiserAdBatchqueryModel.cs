using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayCommerceIotAdvertiserAdBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotAdvertiserAdBatchqueryModel : AopObject
    {
        /// <summary>
        /// 是否只要总大小
        /// </summary>
        [XmlElement("only_total")]
        public bool OnlyTotal { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页大小(<=50)
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
