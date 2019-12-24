using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayMerchantWeikeSettleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantWeikeSettleQueryModel : AopObject
    {
        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlArray("out_biz_no")]
        [XmlArrayItem("string")]
        public List<string> OutBizNo { get; set; }

        /// <summary>
        /// 分页查询页号，从1开始
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页查询页大小，最大100
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
