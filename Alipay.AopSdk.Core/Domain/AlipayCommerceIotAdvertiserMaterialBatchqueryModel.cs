using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayCommerceIotAdvertiserMaterialBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotAdvertiserMaterialBatchqueryModel : AopObject
    {
        /// <summary>
        /// 查询总数
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
